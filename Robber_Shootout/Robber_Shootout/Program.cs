using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter No. of Robbers: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter The Robber with whom Sam will start shooting: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the gap between the robbers: ");
        int gap = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int current = start;
        int shots = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.WriteLine($"Target = {current}, {i} shots completed");
                shots++;
            }
            else
            {
                int next = current + gap;
                if (next > n)
                {
                    next = next - n;
                }
                Console.WriteLine($"Target = {next}, {i} shots completed");
                shots++;

                current = next;
            }
        }

        Console.WriteLine($"{shots} shots taken");
    }
}
