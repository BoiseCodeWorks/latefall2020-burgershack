using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using latefall2020_burgershack.Models;
using latefall2020_burgershack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace latefall2020_burgershack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BurgersController : ControllerBase
    {
        private readonly BurgersService _bs;

        public BurgersController(BurgersService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Burger>> Get()
        {
            try
            {
                return Ok(_bs.Get());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Burger> GetById(int id)
        {
            try
            {
                return Ok(_bs.GetById(id));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Burger> Create([FromBody] Burger burger)
        {
            try
            {
                return Ok(_bs.Create(burger));
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
