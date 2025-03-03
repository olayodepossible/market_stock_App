using stock_app.Dto.Resp;
using stock_app.Models;

namespace stock_app.Mappers
{
    public static class StockMapper
    {
        public static StockRespDto ToStockRespDto(this Stock stockModel){
            return new StockRespDto{
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDividend = stockModel.LastDividend,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap

            };
        }
        public static Stock ToStockFromStockReqDto(this StockReqDto stockReqDto){
            return new Stock{
                Symbol = stockReqDto.Symbol,
                CompanyName = stockReqDto.CompanyName,
                Purchase = stockReqDto.Purchase,
                LastDividend = stockReqDto.LastDividend,
                Industry = stockReqDto.Industry,
                MarketCap = stockReqDto.MarketCap

            };
        }
    }
}