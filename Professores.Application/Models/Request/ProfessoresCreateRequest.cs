using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Application.Models.Request
{
    public class ProfessoresCreateRequest
    {
        [Required(ErrorMessage = "Nome do cliente é obrigatório.")]
        [RegularExpression(pattern: "^[A-Za-zÀ-Üà-ü\\s]{6,150}$",
           ErrorMessage = "Informe um nome válido de 6 a 150 caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A matrícula é obrigatório.")]
        [RegularExpression(pattern: "^[0-9]{11}$",
           ErrorMessage = "Informe uma matricula com exatamente 11 dígitos.")]
        public string? Matricula{ get; set; }

        [Required(ErrorMessage = "Cpf do cliente é obrigatório.")]
        [RegularExpression(pattern: "^[0-9]{11}$",
           ErrorMessage = "Informe um cpf com exatamente 11 dígitos.")]
        public string? Cpf { get; set; }
    }
}
