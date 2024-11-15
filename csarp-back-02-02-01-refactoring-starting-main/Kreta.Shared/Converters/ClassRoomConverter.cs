using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Dtos;

namespace Kreta.Shared.Converters
{
    public class ClassRoomConverter
    {
        public static ClassRoomDto ToDto(ClassRoom classroom)
        {
            return new ClassRoomDto
            {
                Id = classroom.Id,
                Name = classroom.Name,
                Capacity = classroom.Capacity,
                Floor = classroom.Floor,

            };
        }

        public static ClassRoom ToModel(ClassRoomDto classroom)
        {
            return new ClassRoom
            {
                Id = classroom.Id,
                Name = classroom.Name,
                Capacity = classroom.Capacity,
                Floor = classroom.Floor,
            };
        }

        public static List<ClassRoomDto> GetClassRoomsDtos(List<ClassRoom> classrooms)
        {
            return classrooms.Select(classroom => ToDto(classroom)).ToList();
        }

        

        public static List<ClassRoom> GetParents(List<ClassRoomDto> classRooomDtos)
        {
            return classRooomDtos.Select(classRooomDto => ToModel(classRooomDto)).ToList();
        }
    }
}
