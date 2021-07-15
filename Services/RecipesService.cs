using System.Collections.Generic;
using AllSpice.Data;
using AllSpice.Models;

namespace AllSpice.Services
{
  public class RecipesService
  {
    private readonly RecipesRepository _recipesRepo;

    public RecipesService(RecipesRepository recipesRepo)
    {
      _recipesRepo = recipesRepo;
    }

    public List<Recipe> GetAll()
    {
      return _recipesRepo.GetAll();
    }

    public Recipe CreateRecipe(Recipe recipeData)
    {
      return _recipesRepo.Create(recipeData);
    }
  }
}