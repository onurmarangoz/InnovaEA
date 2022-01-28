using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Queries
{
    public class GetProductByIdQueryRequest
    {
        public int Id { get; set; }
    }
}
