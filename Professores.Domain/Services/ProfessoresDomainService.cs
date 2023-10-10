using ProfessoresApi.Domain.Entities;
using ProfessoresApi.Domain.Interfaces.Repositories;
using ProfessoresApi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProfessoresApi.Domain.Services
{
    public class ProfessoresDomainService: IProfessoresDomainService
    {
        private readonly IProfessoresRepository _professoresRepository;

        public ProfessoresDomainService(IProfessoresRepository professoresRepository)
        {

            _professoresRepository = professoresRepository;
        }

        public void Create(Professor entity)
        {          
         
            _professoresRepository.Create(entity); ;
        }

        public void Update(Professor entity)
        {
            var professor = _professoresRepository.GetById((Guid)entity.Id);

            professor.Nome = entity.Nome;
            professor.Matricula = entity.Matricula;
            professor.Cpf = entity.Cpf;
            professor.DataCadastro = entity.DataCadastro = DateTime.Now;


            _professoresRepository.Update(professor);

        }

        public void Delete(Professor entity)
        {
            var professor = _professoresRepository.GetById((Guid)entity.Id);

            _professoresRepository.Delete(professor);

        }

        public List<Professor> GetAll()
        {
           return _professoresRepository.GetAll();
        }

        public Professor GetById(Guid id)
        {
            var professor = _professoresRepository.GetById(id);

            return professor;
        }
    }
}
