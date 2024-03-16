using static System.Console;
namespace Ex_8_1
{
    internal class Program
    {
        public struct AEROFLOT
        {
            public string destination;
            public int flightNumber;
            public string aircraftType;
        }
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            OutputEncoding = System.Text.Encoding.UTF8;
            AEROFLOT[] flights = new AEROFLOT[3];

            for (int i = 0; i < flights.Length; i++)
            {
                WriteLine($"Введите данные для рейса №{i + 1}:");
                Write("Название пункта назначения: ");
                string destination = ReadLine();
                Write("Номер рейса: ");
                int flightNumber = int.Parse(ReadLine());
                Write("Тип самолета: ");
                string aircraftType = ReadLine();

                flights[i] = new AEROFLOT { destination = destination, flightNumber = flightNumber, aircraftType = aircraftType };
            }

            Array.Sort(flights, (x, y) => x.flightNumber.CompareTo(y.flightNumber));

            WriteLine("Введите название пункта назначения для поиска рейсов:");
            string searchDestination = ReadLine();

            bool found = false;
            foreach (var flight in flights)
            {
                if (flight.destination.Equals(searchDestination, StringComparison.OrdinalIgnoreCase))
                {
                    WriteLine($"Рейс №{flight.flightNumber}, Тип самолета: {flight.aircraftType}");
                    found = true;
                }
            }

            if (!found)
            {
                WriteLine("Рейсов в указанный пункт назначения не найдено.");
            }

            ReadLine();
        }
    }
}