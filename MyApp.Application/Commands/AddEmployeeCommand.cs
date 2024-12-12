using MediatR;
using MyApp.Core.Entites;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee):IRequest<EmployeeEntity>;


    public class AddEmployeeCommandHandelar(IEmployeeRepository employeeRepository)
        : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.AddEmployeeAsync(request.Employee);
        }
    }
}
