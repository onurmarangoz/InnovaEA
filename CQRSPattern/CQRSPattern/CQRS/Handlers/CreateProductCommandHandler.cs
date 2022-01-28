using CQRSPattern.CQRS.Commands;
using CQRSPattern.Data;
using CQRSPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Handlers
{
    public class CreateProductCommandHandler : ICommandHandler<CreateProductRequestCommand, CreateProductCommandResponse>
    {
        private InnovaEADbContext context;

        public CreateProductCommandHandler(InnovaEADbContext context)
        {
            this.context = context;
        }
        public CreateProductCommandResponse ExecuteCommand(CreateProductRequestCommand request)
        {
            var product = new Product { Name = request.Name, Description = request.Description, Price = request.Price };

            context.Products.Add(product);
            var affectedRows = context.SaveChanges();
            return new CreateProductCommandResponse { Id = product.Id, IsSuccess = affectedRows > 0 };
        }
    }
}
