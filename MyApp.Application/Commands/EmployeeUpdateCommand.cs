using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Core.Entites;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record EmployeeUpdateCommand(Guid EmployeeId, EmployeeEntity Employee):IRequest<EmployeeEntity>;


    public class EmployeeUpdateCommandHandelar(IEmployeeRepository employeeRepository)
        : IRequestHandler<EmployeeUpdateCommand, EmployeeEntity>
    {
        public Task<EmployeeEntity> Handle(EmployeeUpdateCommand request, CancellationToken cancellationToken)
        {
            return employeeRepository.UpdateEmployeeAsync(request.EmployeeId, request.Employee);
        }
    }


}
