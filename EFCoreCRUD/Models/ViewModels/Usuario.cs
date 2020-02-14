using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD.Models.ViewModels
{
    public class Usuario
    {
        [Key]
        [Display(Name = "Código")]
        public int? Codigo { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [DataType(DataType.Text)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Idade")]        
        public int Idade { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        [DataType(DataType.Text)]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Display(Name = "Informações Complementares")]
        [DataType(DataType.MultilineText)]
        public string InfoComplentares { get; set; }
    }
}
