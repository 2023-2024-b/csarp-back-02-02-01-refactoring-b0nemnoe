namespace Kreata.Backend.Datas.Entities
{
    public class ClassRoom
    {
        public ClassRoom()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
            Capacity = 0;
            Floor = 0;
        }
        public ClassRoom(string name, int capacity, int floor)
        {
            Id = Guid.NewGuid();
            Name = name;
            Capacity = capacity;
            Floor = floor;
        }

        public ClassRoom(Guid id, string name, int capacity, int floor)
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

        public override string ToString()
        {
            return $"Terem: {Name} Szint: {Floor} Kapacitás: {Capacity}";
        }
    }
}
