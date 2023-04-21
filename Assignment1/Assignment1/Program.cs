
        Console.Write("Enter month (1 for Jan, 2 for Feb, 12 for Dec...): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day of week for the first date of the month (1 for Mon, 2 for Tue, 7 for Sun...): ");
        int firstDay = Convert.ToInt32(Console.ReadLine());

        int daysInMonth = DateTime.DaysInMonth(year, month);


        Console.WriteLine("Calendar");
        Console.WriteLine(" S  M  Tu W Th  F  S");

        
        for (int i = 1; i <= firstDay; i++)
        {
            Console.Write("   ");
        }

        
        for (int i = 1; i <= daysInMonth; i++)
        {
            Console.Write("{0,2} ", i);

            
            if ((i + firstDay ) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
   