using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Dtos;

namespace Kreata.Backend.Extensions
{
    public static class ParentExtension
    {
        public static ParentDto ToParentDto(this Parent parent)
        {
            return new ParentDto
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                Address = parent.Address,
                IsWomen = parent.IsWomen,
            };
        }

        public static Parent ToParent(this ParentDto parentDto)
        {
            return new Parent
            {
                Id = parentDto.Id,
                FirstName = parentDto.FirstName,
                LastName = parentDto.LastName,
                Address = parentDto.Address,
                IsWomen = parentDto.IsWomen,
            };
        }
    }
}
