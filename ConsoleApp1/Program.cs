using ConsoleApp1;

Pharmacy pharmacy = new Pharmacy();

string option;


do
{
    Console.WriteLine("\n1. Derman yarat");
    Console.WriteLine("2. Dermanlara bax");
    Console.WriteLine("3. Verilmis kateqoriya ucun dermanlari goster");

    Console.WriteLine("\nSecim edin:");
    option = Console.ReadLine();


    switch (option)
    {
        case "1":
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Category:");
            string category = Console.ReadLine();

            Console.WriteLine("Price:");
            string priceStr = Console.ReadLine();
            double price = Convert.ToDouble(priceStr);

            Medicine medicine = new Medicine
            {
                Name = name,
                Category = category,
                Salary = price,

            };

            pharmacy.AddMedicine(medicine);
            break;

        case "2":

            for (int i = 0; i < pharmacy.Medicinies.Length; i++)
            {
                Console.WriteLine($"\nName:  {pharmacy.Medicinies[i].Name}");
                Console.WriteLine($"Price: {pharmacy.Medicinies[i].Salary}");
                Console.WriteLine($"Category: {pharmacy.Medicinies[i].Category}");
            }
            break;

        case "3":
            Console.WriteLine("Kateqoriyani daxil edin:");
            string searchMedicine = Console.ReadLine();

            for (int i = 0; i < pharmacy.Medicinies.Length; i++)
            {
                if (pharmacy.Medicinies[i].Category.Contains(searchMedicine))
                {
                    Console.WriteLine($"\nName:  {pharmacy.Medicinies[i].Name}")  ;
                    Console.WriteLine($"Price: {pharmacy.Medicinies[i].Salary}");
                }
            }
            break;
        default:
            break;
    }
}





while (option != "0");