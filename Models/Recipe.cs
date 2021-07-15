using System.ComponentModel.DataAnnotations;

namespace AllSpice.Models
{
  public class Recipe
  {
    public int Id { get; set; }
    [Required]
    public string Dish { get; set; }
  }
}