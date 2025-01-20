using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stock_app.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
    }
}