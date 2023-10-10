using ProfessoresApi.Application.Models.Request;
using ProfessoresApi.Application.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessoresApi.Application.Interfaces
{
    public interface IProfessoresAppService
    {
        ProfessoresResponse Create(ProfessoresCreateRequest request);
        ProfessoresResponse Update(ProfessoresUpdateRequest request);

        ProfessoresResponse Delete(Guid id);

        List<ProfessoresResponse> GetAll();

        ProfessoresResponse GetById(Guid id);
    }
}
