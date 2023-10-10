using AutoMapper;
using ProfessoresApi.Application.Models.Request;
using ProfessoresApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProfessoresApi.Application.Mappings
{
    public class ModelToEntityMap: Profile
    {
        public ModelToEntityMap() 
        {

            CreateMap<ProfessoresCreateRequest, Professor>()
                .AfterMap((src, dest) =>
                {
                    dest.Id = Guid.NewGuid();
                    dest.DataCadastro = DateTime.Now;

                });

            CreateMap<ProfessoresUpdateRequest, Professor>();

        }
    }
}
