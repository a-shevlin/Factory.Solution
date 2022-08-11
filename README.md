# Dr Sillystringz's Factory

#### By _**Alex Shevlin**_ 

#### _A web app that allows a Factory Manager to manage Engineers and Machines._  

---

## Table of Contents

**[Technologies Used](#technologies-used)  
[Description](#description)  
[Technology Requirements](#technology-requirements)  
[Setup and Installation](#setupinstallation-requirements)  
[Known Bugs](#known-bugs)  
[License](#license)  
[Known Bugs](#known-bugs)**

---

## Technologies Used

* _C#_
* _.NET_
* _MVC_
* _HTML_
* _CSS_
* _REPL_
* _EntityFrameWork_
* _MySQL WorkBench_

## Description

_This is an MVC application to help a Factory keep track of Engineers and Machines. Engineers and Machines can be added independently to individual lists. Any Engineer or Machine can be selected and shown details. That page displays the number of relationships between the selected class and the Licenses that are stored in the application._

---
## Setup/Installation Requirements

<details>
<summary><strong>Install</strong></summary>
<ol>
<li>Install <a href="https://git-scm.com/download/">Git </a>and follow setup wizard
<li><a href="https://dotnet.microsoft.com/en-us/download/dotnet/5.0">Microsoft .NET SDK 5.0</a> and follow setup wizard
<li><a href="https://dev.mysql.com/downloads/workbench/">MySQL</a>, follow setup wizard, and create a localhost server on port 3306
<li>Clone this project and place files in a folder named `Factory.Solution`
    <pre>Factory.Solution
    └── Factory</pre>
</ol>
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>
<ol>
<li>Create an appsettings.json file in the "Factory" directory of the project*  
   <pre>Factory.Solution
   └── Factory
    └── appsettings.json</pre>
<li> Insert the following code** : <br>

<pre>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=alex_shevlin;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}</pre>
<small>*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".</small><br>
<small>**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.</small>

<li>Once "appsettings.json" file has been created, open your git terminal.
<br><br>
How to Import a Database:
<ol> 
<li>In the Factory.Solutions/Factory folder run
  <li><strong>$ dotnet ef migrations add restoreDatabase</strong> in the console
  <li><strong>$ dotnet ef database update</strong> in the console
  <li>Open SQL Workbench.
  <li>Navigate to "Factory" schema.
  <li>Click the drop down, select "Tables" drop down.
  <li>Verify the tables, you should see <strong>disciple</strong>, <strong>disciplesensei</strong>, <strong>martialart</strong>, &<strong> sensei</strong>.
</details>

<details>
<summary><strong>To Run</strong></summary>
Navigate to  
   <pre>Factory.Solution
   └── <strong>Factory</strong></pre>
<ol>
  <li>Run <strong>$ dotnet restore</strong> in the console
  <li>Run <strong>$ dotnet run</strong> in the console
</details>
<br>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* _No known bugs_

## License

[GNU](/LICENSE-GNU)

Copyright (c) 2022 Alex Shevlin
