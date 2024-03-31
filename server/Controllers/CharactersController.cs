using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace easilyswadecsharp.Controllers
{
  [ApiController]
  [Route("api/characters")]
  public class CharactersController : ControllerBase
  {
    private readonly CharactersService charactersService;
    private readonly Auth0Provider _auth;

    public CharactersController(CharactersService charactersService, Auth0Provider auth)
    {
      this.charactersService = charactersService;
      _auth = auth;
    }

    [HttpGet]
    public ActionResult<List<Character>> GetAllCharacters()
    {
      try
      {
        List<Character> characters = charactersService.GetAllCharacters();
        return Ok(characters);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{characterId")]
    public ActionResult<Character> GetCharacterById(int characterId)
    {
      try
      {
        Character character = charactersService.GetCharacterById(characterId);
        return Ok(character);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Character>> CreateCharacter([FromBody] Character characterData)
    {
      try
      {
        Account userInfo = await _auth.GetUserInfoAsync<Account>(HttpContext);
        characterData.CreatorId = userInfo.Id;
        Character character = charactersService.CreateCharacter(characterData);
        character.Creator = userInfo;
        return Ok(character);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}