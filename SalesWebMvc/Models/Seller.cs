using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        //tamanho máximo / mínimo digitos
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve possuir entre {2} a {1} caracteres!")] 
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [Display(Name = "Birth Date")] //customizando nas views o display dos campos
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required!")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve estar entre {1} a {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }
        
        //Department -> classe seller possuir 1 department
        public Department Department { get; set; }

        //Garantir integridade referencial no banco com a tabela Departament
        public int DepartmentId { get; set; }

        //Classe Seller possui `N` registros de vendas...
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime ini, DateTime fim)
        {
            return Sales.Where(sr => sr.Date >= ini && sr.Date <= fim).Sum(sr => sr.Amount);
        }
    }
}
