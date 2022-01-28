using CQRSPattern.CQRS.Commands;
using CQRSPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Handlers
{
    public class DeleteCommandHandler : ICommandHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>

    {
        private InnovaEADbContext context;

        public DeleteCommandHandler(InnovaEADbContext context)
        {
            this.context = context;
        }
        public DeleteProductCommandResponse ExecuteCommand(DeleteProductCommandRequest request)
        {
            var existingProduct = context.Products.FirstOrDefault(x => x.Id == request.Id);
            var deletingProduct = context.Products.Remove(existingProduct);
            var count = context.SaveChanges();
            return new DeleteProductCommandResponse { IsSuccess = count > 0 };


        }
    }
}
