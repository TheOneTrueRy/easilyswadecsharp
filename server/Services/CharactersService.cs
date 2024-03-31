using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace easilyswadecsharp.Services;
public class CharactersService
{
  private readonly CharactersRepository _repo;

  public CharactersService(CharactersRepository repo)
  {
    _repo = repo;
  }
}