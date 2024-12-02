using System;
using HotelReservation.Model.Rooms;
using HotelReservation.Persistence.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.UI.WebApp.Controller;

[Route("api/luxousRoom")]
[ApiController]
public class LuxousRoomController :ControllerBase
{
    private readonly HotelReservationEFCoreContext context;

    public LuxousRoomController(HotelReservationEFCoreContext context) {
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var luxousRoom = await context.QuartoLuxo.ToListAsync();
        return Ok(luxousRoom);
    }

    [HttpPost] 
    public async Task<IActionResult> Create(QuartoLuxo luxousRoom) {
        context.Add(luxousRoom);
        await context.SaveChangesAsync();
        return Created("Quarto de luxo criado com sucesso!", luxousRoom);
    }

    [HttpPut]
    public async Task<IActionResult> Update(QuartoLuxo luxousRoom) {
        context.Entry(luxousRoom).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(luxousRoom);
    }

}
