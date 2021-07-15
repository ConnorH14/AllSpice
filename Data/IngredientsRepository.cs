using System.Collections.Generic;
using System.Data;
using System.Linq;
using AllSpice.Models;
using Dapper;

namespace AllSpice.Data
{
  public class IngredientsRepository
  {
    private readonly IDbConnection _db;

    public IngredientsRepository(IDbConnection db)
    {
      _db = db;
    }

    public List<Ingredient> GetAll()
    {
      var sql = "SELECT * FROM ingredients";
      return _db.Query<Ingredient>(sql).ToList();
    }

    public Ingredient Create(Ingredient ingredientData)
    {
      var sql = @"
        INSERT INTO ingredients(ingname)
        VALUES(@IngName);
        SELECT LAST_INSERT_ID();
      ";

      int id = _db.ExecuteScalar<int>(sql, ingredientData);
      ingredientData.Id = id;
      return ingredientData;
    }
  }
}