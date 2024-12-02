using System;
using HotelReservation.Model.Rooms;
using HotelReservation.Persistence.DataContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.UI.WebApp.Controller;

[Route("api/suite")]
[ApiController]
public class SuiteController : ControllerBase
{
    private readonly HotelReservationEFCoreContext context;

    public SuiteController(HotelReservationEFCoreContext context) {
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var suite = await context.Suite.ToListAsync();
        return Ok(suite);
    }

    [HttpPost] 
    public async Task<IActionResult> Create(Suite suite) {
        context.Add(suite);
        await context.SaveChangesAsync();
        return Created("Quarto de luxo criado com sucesso!", suite);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Suite suite) {
        context.Entry(suite).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(suite);
    }

}
