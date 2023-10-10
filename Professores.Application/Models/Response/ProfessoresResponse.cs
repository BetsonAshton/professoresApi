using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Application.Models.Response
{
    public class ProfessoresResponse
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public string? Cpf { get; set; }

        public DateTime? DataCadastro { get; set; }

        public ProfessoresResponse()
        {
            DataCadastro = DateTime.Now;
        }

    }
}
