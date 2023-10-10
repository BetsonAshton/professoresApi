using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Domain.Entities
{
   public class Professor
    {
        private Guid? _id;
        private string? _nome;
        private string? _matricula;
        private string? _cpf;
        private DateTime? _dataCadastro;

        public Guid? Id { get => _id; set => _id = value; }
        public string? Nome { get => _nome; set => _nome = value; }
        public string? Matricula { get => _matricula; set => _matricula = value; }
        public string? Cpf { get => _cpf; set => _cpf = value; }
        public DateTime? DataCadastro { get => _dataCadastro; set => _dataCadastro = value; }
    }
}
