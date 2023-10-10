using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfessoresApi.Application.Interfaces;
using ProfessoresApi.Application.Models.Request;
using ProfessoresApi.Application.Models.Response;

namespace ProfessoresApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase
    {
        private readonly IProfessoresAppService _professoresAppServices;

        public ProfessoresController(IProfessoresAppService professoresAppServices)
        {
            _professoresAppServices = professoresAppServices;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ProfessoresResponse), 201)]
        public IActionResult Post(ProfessoresCreateRequest request)
        {
            return StatusCode(201, new
            {
                mensagem = "Professor cadastrado com sucesso.",
                professor = _professoresAppServices.Create(request)
            });
        }

        [HttpPut]
        public IActionResult Put(ProfessoresUpdateRequest request)
        {
            return StatusCode(200, new
            {
                mensagem = "Professor atualizado com sucesso.",
                professor = _professoresAppServices.Update(request),
                
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return StatusCode(200, new
            {
                mensagem = "O seguinte Professor foi excluido com sucesso.",
                professor = _professoresAppServices.Delete(id)
            });
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProfessoresResponse>), 200)]
        public IActionResult GetAll() 
        {
            return StatusCode(200, _professoresAppServices.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return StatusCode(200, _professoresAppServices.GetById(id));
        }
    }
}
