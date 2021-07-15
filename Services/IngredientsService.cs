using System.Collections.Generic;
using AllSpice.Data;
using AllSpice.Models;

namespace AllSpice.Services
{
  public class IngredientsService
  {
    private readonly IngredientsRepository _ingredientsRepo;

    public IngredientsService(IngredientsRepository ingredientsRepo)
    {
      _ingredientsRepo = ingredientsRepo;
    }

    public List<Ingredient> GetAll()
    {
      return _ingredientsRepo.GetAll();
    }

    public Ingredient CreateIngredient(Ingredient ingredientsData)
    {
      return _ingredientsRepo.Create(ingredientsData);
    }
  }
}