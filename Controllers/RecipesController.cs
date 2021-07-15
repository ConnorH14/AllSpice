using System.Collections.Generic;
using AllSpice.Models;
using AllSpice.Services;
using Microsoft.AspNetCore.Mvc;

namespace AllSpice.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class RecipesController : ControllerBase
  {
    private readonly RecipesService _rs;
    public RecipesController(RecipesService rs)
    {
      _rs = rs;
    }

    [HttpGet]
    public ActionResult<List<Recipe>> GetRecipes()
    {
      try
      {
        var recipes = _rs.GetAll();
        return Ok(recipes);

      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Recipe> CreateRecipe([FromBody] Recipe recipeData)
    {
      try
      {
        var recipe = _rs.CreateRecipe(recipeData);
        return Created($"api/recipes/" + recipe.Id, recipe);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}