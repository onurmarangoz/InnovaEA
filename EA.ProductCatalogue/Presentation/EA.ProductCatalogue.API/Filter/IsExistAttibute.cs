using EA.ProductCatalogue.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.API.Filter
{
    public class IsExistAttibute : IAsyncActionFilter
    {
        private IProductService productService;

        public IsExistAttibute(IProductService productService)
        {
            this.productService = productService;
        }
       
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = context.ActionArguments["id"];
            int entityId = (int)id;
            var isExist = entityId > 0 && await productService.ProductIsExist(entityId);
            if (!isExist)
            {
                context.Result = new NotFoundObjectResult(entityId);
                return;
            }

            await next();
        }
    }
}
