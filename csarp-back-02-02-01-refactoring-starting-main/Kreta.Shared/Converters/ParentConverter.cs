using Kreata.Backend.Datas.Entities;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.Datas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Converters
{
    public class ParentConverter
    {
        public static ParentDto ToDto(Parent parent)
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

        public static Parent ToModel(ParentDto parent)
        {
            return new Parent
            {
                Id = parent.Id,
                FirstName = parent.FirstName,
                LastName = parent.LastName,
                Address = parent.Address,
                IsWomen = parent.IsWomen,
            };
        }

        public static List<ParentDto> GetParentsDtos(List<Parent> parents)
        {
            return parents.Select(parent => ToDto(parent)).ToList();
        }
        public static List<Parent> GetParents(List<ParentDto> studentDtos)
        {
            return studentDtos.Select(parentDto => ToModel(parentDto)).ToList();
        }
    }
}
