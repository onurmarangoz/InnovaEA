using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.API.Filter
{
    public class ProductExistAttribute : TypeFilterAttribute
    {
        public ProductExistAttribute() : base(typeof(IsExistAttibute))
        {

        }
    }
}
