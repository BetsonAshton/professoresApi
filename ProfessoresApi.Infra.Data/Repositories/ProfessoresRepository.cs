using Microsoft.EntityFrameworkCore;
using ProfessoresApi.Domain.Entities;
using ProfessoresApi.Domain.Interfaces.Repositories;
using ProfessoresApi.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Infra.Data.Repositories
{
    public class ProfessoresRepository : IProfessoresRepository
    {
        public void Create(Professor entity)
        {
            using(var dataContext = new DataContext()) 
            { 
                dataContext.Professores.Add(entity);
                dataContext.SaveChanges();
            
            }
        }

        public void Update(Professor entity)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();

            }
        }

        public void Delete(Professor entity)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Professores.Remove(entity);
                dataContext.SaveChanges();

            }
        }

        public List<Professor> GetAll()
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Professores
                    .OrderBy(c => c.Nome)
                    .ToList();

            }
        }

        public Professor GetById(Guid id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Professores.FirstOrDefault(c => c.Id == id);

            }
        }
    }
}
