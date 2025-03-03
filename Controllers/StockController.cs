using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using stock_app.Dto.Resp;

namespace stock_app.Controllers
{
    [Route("api/stocks")]
    [ApiController]
    public class StockController : ControllerBase
    {
        public StockController()
        {
            
        }

        [HttpGet("{id}")]
        public IActionResult GetStockById([FromRoute] int id){
            return null;
        }

        [HttpPost]
        public IActionResult createStock([FromBody] StockReqDto dto){
            return null;
        }
        
    }
}