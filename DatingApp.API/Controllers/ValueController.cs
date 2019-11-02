using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly DataContext context;

        public ValueController(DataContext context)
        {
            this.context = context;

        }
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            // throw new Exception("Test exception");
            var values = await context.Employees.ToListAsync();
            return Ok(values);
        }

        [ HttpGet]
        [ Route("{id}")]
         public async Task<IActionResult> GetValue(int id)
        {
            // throw new Exception("Test exception");
            var value = await context.Employees.FirstOrDefaultAsync(record =>record.Id==id);
            return Ok(value);
        }
    }
}