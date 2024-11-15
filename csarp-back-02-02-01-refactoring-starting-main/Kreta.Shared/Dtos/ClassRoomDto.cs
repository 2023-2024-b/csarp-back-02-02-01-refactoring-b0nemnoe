using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Dtos
{
    public class ClassRoomDto
    {
        public ClassRoomDto()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            Capacity = 0;
            Floor = 0;
        }
        public ClassRoomDto(string name, int capacity, int floor)
        {
            Id = Guid.NewGuid();
            Name = name;
            Capacity = capacity;
            Floor = floor;
        }

        public ClassRoomDto(Guid id, string name, int capacity, int floor)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            Floor = floor;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Floor { get; set; }
    }
}
