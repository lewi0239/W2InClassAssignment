namespace W2InClassAssignment
{
    class RaceCar
    {
        public string vehicleName { get; set; }
        public int horsePower { get; }

        public RaceCar(string vehicleName, int horsePower)
        {
            this.vehicleName = vehicleName;
            this.horsePower = horsePower;
        }
        
        public void Describe()
        {
            Console.WriteLine($"This is a {vehicleName} has {horsePower}");
        }
    }
    class Engine
    {
        public int horsePower { get; set; }
        
        public Engine(int horsePower)
        {
            this.horsePower = horsePower;
        }
    }
    
}