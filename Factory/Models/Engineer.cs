using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateHired { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}