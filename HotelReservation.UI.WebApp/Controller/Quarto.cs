using HotelReservation.Model.Rooms;
using HotelReservation.Persistence.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.CRUD;

namespace HotelReservation.UI.WebApp.Controller;

[Route("api/rooms")]
[ApiController]

public class RoomController : ControllerBase
{

    private readonly HotelReservationEFCoreContext context;
    public RoomController(HotelReservationEFCoreContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var rooms = await context.Quarto.ToListAsync();
        return Ok(rooms);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetByID(int roomID)
    {
        Quarto? room = await context.QuartoLuxo.FindAsync(roomID);
        return Ok(room);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromQuery] int[] roomID)
    {
        //FromQUery é necessário para ler a query string do corpo da requisição ex: '?roomID=4&roomID=5'
        if (roomID == null || !roomID.Any())
        {
            return NoContent();
        }

        var rooms = await context.Quarto.Where(q => roomID
            .Contains(q.Id))
            .ToListAsync();

        if (!rooms.Any())
        {
            return NoContent();
        }

        context.RemoveRange(rooms);
        await context.SaveChangesAsync();

        return Ok();
    }

}


/*
Cola:

Tipo de Parâmetro	Anotação Requerida	Fonte da Requisição

Query String (?id=1)	[FromQuery]	      URL (query string)

Corpo da Requisição	    [FromBody]	      JSON/XML/Body

Cabeçalhos          	[FromHeader]	  Headers

Rota	                [FromRoute]	      URL Path
*/