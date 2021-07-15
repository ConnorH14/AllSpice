using System.ComponentModel.DataAnnotations;

namespace AllSpice.Models
{
  public class Ingredient
  {
    public int Id { get; set; }
    [Required]
    public string IngName { get; set; }
  }
}