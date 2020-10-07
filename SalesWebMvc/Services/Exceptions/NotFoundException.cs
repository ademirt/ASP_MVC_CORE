using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        /*
         * Exceção personalizada:
         * - Exceções específicas da camada de serviço.
         * - por exemplo para ser usada ao atualizar , excluir um registro
         */
        

        public NotFoundException(string message) : base(message)
        {

        }
    }
}
