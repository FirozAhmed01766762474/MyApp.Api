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
    public record GetAllEmployeesQuery(): IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeesQueryHandela(IEmployeeRepository EmployeeRepository)
        : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await EmployeeRepository.GetEmployees();
        }
    }

}
