using System;

namespace SalesWebMvc.Services.Exceptions
{
    /*
     * Serviço de Exceção para integridade referencial na base de dados
     */
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message) : base(message)
        {

        }
    }
}
