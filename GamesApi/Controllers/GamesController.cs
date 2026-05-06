using GamesApi.Modul;
using GamesApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GamesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase {
    [HttpGet]
    public ActionResult<List<Game>> GetAll() {
        return Ok(GameStore.Games);
    }
}