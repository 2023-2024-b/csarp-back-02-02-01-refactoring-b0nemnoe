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
    public class ClassRoomController : ControllerBase
    {
        private IClassRoomRepo _classRoomRepo;

        public ClassRoomController(IClassRoomRepo classRoomRepo)
        {
            _classRoomRepo = classRoomRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            ClassRoom? classroom = new();
            if (_classRoomRepo is not null)
            {
                classroom = await _classRoomRepo.GetBy(id);
                if (classroom != null)
                    return Ok(classroom.ToClassRoomDto);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<ClassRoom>? classrooms = new();

            if (_classRoomRepo is not null)
            {
                classrooms = await _classRoomRepo.GetAll();
                return Ok(classrooms.Select(classroom => classroom.ToClassRoomDto()));
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
        [HttpPut()]
        public async Task<ActionResult> UpdateClassRoomAsync(ClassRoomDto entity)
        {
            ControllerResponse response = new();
            if (_classRoomRepo is not null)
            {
                response = await _classRoomRepo.UpdateClassRoomAsync(entity.ToClassRoom());
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
