using HotelReservation.Model.Rooms;
using HotelReservation.Persistence.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.UI.WebApp.Controller;

[Route("api/rooms")]
[ApiController]

public class RoomController : ControllerBase {

    private readonly HotelReservationEFCoreContext context;
    public RoomController(HotelReservationEFCoreContext context) {
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var rooms = await context.Quarto.ToListAsync();
        return Ok(rooms);
    }

    [HttpGet("getById")]
    public async Task<IActionResult> GetByID(int roomID) {
        Quarto? room = await context.QuartoLuxo.FindAsync(roomID);
        return Ok(room);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int roomID) {
        Quarto? room = await context.Quarto.FindAsync(roomID);
        if (room != null) {
            context.Remove(room);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

}