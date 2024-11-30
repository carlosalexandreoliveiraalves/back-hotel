using HotelReservation.Model.Rooms;
using HotelReservation.Persistence.DataContext;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HotelReservation.UI.WebApp.Controller;

[Microsoft.AspNetCore.Mvc.Route("api/rooms")]
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
        Quarto? room = await context.Quarto.FindAsync(roomID);
        return Ok(room);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Quarto room) {
        context.Add(room);
        await context.SaveChangesAsync();
        return Created("", room);
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

    [HttpPut]
    public async Task<IActionResult> Update(Quarto room) {
        context.Entry(room).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok();
    }

}