using System.Collections.Generic;
namespace Bakery.Models 
{
  public class Treat 
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }
  }
}
