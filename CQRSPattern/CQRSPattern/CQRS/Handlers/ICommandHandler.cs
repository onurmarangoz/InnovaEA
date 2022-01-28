using CQRSPattern.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Handlers
{
   public interface ICommandHandler<in TRequest, out TResponse> where TRequest:ICommandRequest 
                                                                where TResponse:ICommandResponse 
    {
        TResponse ExecuteCommand(TRequest request);
    }
}
