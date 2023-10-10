using AutoMapper;
using ProfessoresApi.Application.Models;
using ProfessoresApi.Application.Models.Response;
using ProfessoresApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Application.Mappings
{
    public class EntityToModelMap:Profile
    {
        public EntityToModelMap() 
        {
            CreateMap<Professor, ProfessoresResponse>();
        }
    }
}
