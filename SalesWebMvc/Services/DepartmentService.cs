using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //método para listar todos departamentos cadastrados na base...
        //será usado em um componente para selecionar o departamento durante o cadastro de vendedor
        public async Task<List<Department>> FindAllAsync()
        {
            //lista os departamentos ordenados por nome...
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
