namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
       
        public Parent(string firstName, string lastName, string address, bool isWomen)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            IsWomen = isWomen;
        }
        public Parent(Guid id, string firstName, string lastName, string address, bool isWomen)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            IsWomen = isWomen;

        }
        public Parent()
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
        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
