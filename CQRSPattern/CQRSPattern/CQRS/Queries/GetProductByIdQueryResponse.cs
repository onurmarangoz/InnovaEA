using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Queries
{
    public class GetProductByIdQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? StockCount { get; set; }
        public string Description { get; set; }
    }
}
