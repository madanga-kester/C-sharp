namespace ConsoleApp
{
    class CarYardApp
    {
        static void Main(string[] args)
        {
            Console.Write("Please select your desired brand (1. Toyota, 2. Nissan): ");
            int carBrand = Convert.ToInt32(Console.ReadLine());

            string brandChoice = carBrand switch
            {
                1 => "Toyota",
                2 => "Nissan",
                _ => "Invalid Choice"
            };

            Console.WriteLine();
            Console.WriteLine($"You have selected: {brandChoice}");

            if (brandChoice == "Invalid Choice")
            {
                Console.WriteLine("Exiting program...");
                return;
            }

            Console.Write("Please select a model (1. Sijui, 2. Najua): ");
            int model = Convert.ToInt32(Console.ReadLine());

            string modelChoice = model switch
            {
                1 => "Sijui",
                2 => "Najua",
                _ => "Invalid Choice"
            };

            Console.WriteLine();
            Console.WriteLine($"You have selected: {brandChoice} - {modelChoice}");
        }
    }
}
