using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using stock_app.Data;
using stock_app.Models;
using ZstdSharp.Unsafe;

namespace stock_app.Repository
{
    
    public class StockRepository
    {
        private readonly ApplicationDBContext _ctx;
        public StockRepository(ApplicationDBContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<Stock>> GetStocksAsync(){
           var stockList =  await _ctx.Stocks.ToListAsync();
           return stockList;
        }
        public async Task<Stock> GetStockByIdAsync(int id){
           var stock =  await _ctx.Stocks.FindAsync(id);
           return stock;
        }
    }
}