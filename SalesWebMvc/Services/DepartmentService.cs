using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

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
        public List<Department> FindAll()
        {
            //lista os departamentos ordenados por nome...
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
