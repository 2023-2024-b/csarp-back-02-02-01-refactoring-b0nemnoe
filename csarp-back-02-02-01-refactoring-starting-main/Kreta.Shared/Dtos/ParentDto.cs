using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Dtos
{
    public class ParentDto
    {
        public ParentDto(string firstName, string lastName, string address, bool isWomen)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            IsWomen = isWomen;
        }
        public ParentDto(Guid id, string firstName, string lastName, string address, bool isWomen)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            IsWomen = isWomen;

        }
        public ParentDto()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            IsWomen = false;
            Address = string.Empty;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public bool IsWomen { get; set; }
    }
}
