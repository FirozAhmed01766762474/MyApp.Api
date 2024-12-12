using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using MyApp.Core.Entites;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Queries
{
    public record GetEmployeebyIDQuery(Guid id):IRequest<EmployeeEntity>;

    public class GetEmployeebyIDQueryHandeler(IEmployeeRepository employeeRepository)
        : IRequestHandler<GetEmployeebyIDQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeebyIDQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.id);
        }
    }
}
