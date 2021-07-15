using System.Collections.Generic;
using AllSpice.Models;
using AllSpice.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllSpice.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class IngredientsController : ControllerBase
  {
    private readonly IngredientsService _is;
    public IngredientsController(IngredientsService xis)
    {
      _is = xis;
    }

    [HttpGet]
    public ActionResult<List<Ingredient>> GetIngredients()
    {
      try
      {
        var ingredients = _is.GetAll();
        return Ok(ingredients);

      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Ingredient> CreateIngredient([FromBody] Ingredient ingredientData)
    {
      try
      {
        var ingredient = _is.CreateIngredient(ingredientData);
        return Created($"api/recipes/" + ingredient.Id, ingredient);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}