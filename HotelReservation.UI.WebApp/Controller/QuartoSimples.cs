using System;
using HotelReservation.Model.Rooms;
using HotelReservation.Persistence.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.UI.WebApp.Controller;

[Route("api/regularRoom")]
[ApiController]
public class RegularRoomController : ControllerBase
{

private readonly HotelReservationEFCoreContext context;

public RegularRoomController(HotelReservationEFCoreContext context) {
    this.context = context;
}

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var regularRoom = await context.QuartoSimples.ToListAsync();
        return Ok(regularRoom);
    }

    [HttpPost] 
    public async Task<IActionResult> Create(QuartoSimples regularRoom) {
        context.Add(regularRoom);
        await context.SaveChangesAsync();
        return Created("Quarto de luxo criado com sucesso!", regularRoom);
    }

    [HttpPut]
    public async Task<IActionResult> Update(QuartoSimples regularRoom) {
        context.Entry(regularRoom).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(regularRoom);
    }

}
