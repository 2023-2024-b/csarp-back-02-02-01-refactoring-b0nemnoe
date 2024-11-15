using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.Datas.Entities;

namespace Kreata.Backend.Extensions
{
    public static class ClassRoomExtension
    {
        public static ClassRoomDto ToClassRoomDto(this ClassRoom classroom)
        {
            return new ClassRoomDto
            {
                Id = classroom.Id,
                Name = classroom.Name,
                Capacity = classroom.Capacity,
                Floor = classroom.Floor,
            };
        }

        public static ClassRoom ToClassRoom(this ClassRoomDto classroomDto)
        {
            return new ClassRoom
            {
                Id = classroomDto.Id,
                Name = classroomDto.Name,
                Capacity = classroomDto.Capacity,
                Floor = classroomDto.Floor,
            };
        }
    }
}
