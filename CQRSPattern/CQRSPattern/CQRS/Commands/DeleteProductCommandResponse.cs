using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern.CQRS.Commands
{
    public class DeleteProductCommandResponse :ICommandResponse
    {
        public bool IsSuccess { get; set; }
    }
}
