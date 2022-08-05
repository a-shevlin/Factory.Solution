using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    public int Id { get; set; }
    public string Model { get; set; }
    public DateTime DateManufactured { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}