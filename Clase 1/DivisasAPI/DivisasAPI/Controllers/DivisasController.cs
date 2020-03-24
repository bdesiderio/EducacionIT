using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DivisasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisasController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using (FileStream fs = new FileStream("data.json", FileMode.Open))
            {
                using (StreamReader streamReader = new StreamReader(fs))
                {
                    var data = await streamReader.ReadToEndAsync();
                    return Ok(data);
                }
            }

        }
    }
}