namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car
            {
                Year = "2011",
                Make = "Subaru",
                Model = "Forester"
            };



            var ferrari = new Car()
            {
                Make = "ferrari",
                Model = "La Ferrari",
                Year = "2015",
            };


            var Toyota = new Car("Toyota", "Tacoma", 2014);



            var carList = new List<Car>() { myCar, ferrari, Toyota };


            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
        }

    }
}
