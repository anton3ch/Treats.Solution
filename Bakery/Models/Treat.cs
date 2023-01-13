using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The Treat's Name can't be empty!")]
    public string Name { get; set; }
    [Required(ErrorMessage = "The Treat's Details can't be empty!")]
    public string Details { get; set; }
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User { get; set; }  
  }
}