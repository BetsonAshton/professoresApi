using AutoMapper;
using ProfessoresApi.Application.Interfaces;
using ProfessoresApi.Application.Models;
using ProfessoresApi.Application.Models.Request;
using ProfessoresApi.Application.Models.Response;
using ProfessoresApi.Domain.Entities;
using ProfessoresApi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Application.Services
{
    public class ProfessoresAppService : IProfessoresAppService
    {
        private readonly IProfessoresDomainService _professoresDomainService;
        private readonly IMapper _mapper;

        public ProfessoresAppService(IProfessoresDomainService professoresDomainService, IMapper mapper)
        {
            _professoresDomainService = professoresDomainService;
            _mapper = mapper;
        }

        public ProfessoresResponse Create(ProfessoresCreateRequest request) 
        { 
            var professor = _mapper.Map<Professor>(request);
            _professoresDomainService.Create(professor);

            return _mapper.Map<ProfessoresResponse>(professor);


        }

        public ProfessoresResponse Update(ProfessoresUpdateRequest request)
        {
            var professor = _mapper.Map<Professor>(request);
            _professoresDomainService.Update(professor);

            return _mapper.Map<ProfessoresResponse>(professor);


        }

        public ProfessoresResponse Delete(Guid id)
        {
            var professor = _professoresDomainService.GetById(id);
            _professoresDomainService.Delete(professor);
            return _mapper.Map<ProfessoresResponse>(professor);
        }

        public List<ProfessoresResponse> GetAll()
        { 
        
             var professor = _professoresDomainService.GetAll();
            return _mapper.Map<List<ProfessoresResponse>>(professor);
        }

        public ProfessoresResponse GetById(Guid id)
        {
            var professor = _professoresDomainService.GetById(id);
            return _mapper.Map<ProfessoresResponse>(professor);
        }
    }
}
