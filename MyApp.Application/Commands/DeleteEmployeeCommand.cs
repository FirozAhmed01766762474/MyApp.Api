using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
public record DeleteEmployeeCommand(Guid employeeId):IRequest<bool>;


    public class DeleteEmployeeCommandHandelar(IEmployeeRepository employeeRepository)
            : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeeAsync(request.employeeId);
        }
    }
}
