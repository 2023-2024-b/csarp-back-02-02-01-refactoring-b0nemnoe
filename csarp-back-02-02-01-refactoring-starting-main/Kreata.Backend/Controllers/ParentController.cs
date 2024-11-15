using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Extensions;
using Kreata.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : ControllerBase
    {
        private IParentRepo _parentRepo;

        public ParentController(IParentRepo parentRepo)
        {
            _parentRepo = parentRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Parent? parent = new();
            if (_parentRepo is not null)
            {
                parent = await _parentRepo.GetBy(id);
                if (parent != null)
                    return Ok(parent.ToParentDto);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Parent>? parents = new();

            if (_parentRepo != null)
            {
                parents = await _parentRepo.GetAll();
                return Ok(parents.Select(parent => parent.ToParentDto()));
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateParentAsync(ParentDto entity)
        {
            ControllerResponse response = new();
            if (_parentRepo is not null)
            {
                response = await _parentRepo.UpdateParentAsync(entity.ToParent());
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }
    }
}
