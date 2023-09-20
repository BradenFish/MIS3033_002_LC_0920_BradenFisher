namespace a
{
    public class City
    { 
        public int Id { get; set; } 
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
        public override string ToString()
        {
            return $"ID {this.Id} {this.Name} {this.State} {Population}";
        }

    }

}
