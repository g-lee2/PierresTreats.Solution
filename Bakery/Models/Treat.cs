using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models 
{
  public class Treat 
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The item can't be empty!")]
    public string Name { get; set; }
    public string Description { get; set; }
    [Range(0, 999.99)]
    public decimal Price { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
    public ApplicationUser User { get; set; }
  }
}
