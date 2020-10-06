using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    //Classe responsavel por conter os dados para o formulário de cadastro de Sellers
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
