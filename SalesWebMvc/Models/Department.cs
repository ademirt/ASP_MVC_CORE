using System.Collections.Generic;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        //tamanho máximo / mínimo digitos
        [StringLength(30, MinimumLength = 5, ErrorMessage = "{0} deve possuir entre {2} a {1} caracteres!")]
        public string Name { get; set; }

        //Classe Department possui `N` Sellers....
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial,final) );
        }
    }
}
