using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easilyswadecsharp.Repositories;
public class CharactersRepository
{
  private readonly IDbConnection _db;

  public CharactersRepository(IDbConnection db)
  {
    _db = db;
  }
}
