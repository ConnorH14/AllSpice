using System.Collections.Generic;
using System.Data;
using System.Linq;
using AllSpice.Models;
using Dapper;

namespace AllSpice.Data
{
  public class RecipesRepository
  {
    private readonly IDbConnection _db;

    public RecipesRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Recipe> GetAll()
    {
      var sql = "SELECT * FROM recipes";
      return _db.Query<Recipe>(sql).ToList();
    }

    public Recipe Create(Recipe recipeData)
    {
      var sql = @"
        INSERT INTO recipes(dish)
        VALUES(@Dish);
        SELECT LAST_INSERT_ID();
      ";

      int id = _db.ExecuteScalar<int>(sql, recipeData);
      recipeData.Id = id;
      return recipeData;
    }
  }
}