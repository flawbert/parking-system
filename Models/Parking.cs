namespace Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.initialPrice = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Write the vehicle's license plate:");
            string plate = Console.ReadLine();
            if (!vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                vehicles.Add(plate);
                Console.WriteLine($"The vehicle {plate} has been added successfully."); 
            }
            else
            {
                Console.WriteLine("This vehicle is already parked here.");
            }
        }
        public void RemoveVehicle()
        {
            Console.WriteLine("Please enter the license plate of the vehicle you want to remove:");
            string plate = Console.ReadLine();
            if (vehicles.Any(x => x.ToUpper() == plate.ToUpper()))
            {
                Console.WriteLine("Vehicle found! Now, let's calculate the total amount to be paid. Insert the number of hours the vehicle was parked:");
                int hoursParked = Convert.ToInt32(Console.ReadLine());
                decimal totalPrice = initialPrice + (pricePerHour * hoursParked);

                vehicles.Remove(plate);

                Console.WriteLine($"The vehicle {plate} has been removed successfully. The total amount to be paid is: R$ {totalPrice}");
            }
            else
            {
                Console.WriteLine("This vehicle is not parked here. Try again.");
            }
        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            {
                Console.WriteLine("Currently parked vehicles:");
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine($"- {vehicle}");

                }
            }   
            else
                {
                    Console.WriteLine("No vehicles are currently parked.");
                }
        }
    }
}
