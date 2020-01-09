using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AsyncTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsyncTest : ControllerBase
    {
        [HttpGet("noawait")]
        public async Task<IActionResult> GetNoAwait()
        {
            MethodAsync();
            return Ok("GetNoAwait");
        }

        [HttpGet("await")]
        public async Task<IActionResult> GetAwait()
        {
            await MethodAsync();
            return Ok("GetNoAwait");
        }

        private async Task MethodAsync()
        {
            await Task.Delay(5000);
            System.Diagnostics.Debug.WriteLine("Se ejecuto el Delay");
        }
    }
}
