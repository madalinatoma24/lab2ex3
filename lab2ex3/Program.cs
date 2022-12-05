using System;

namespace lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Ex 3 Să se scrie un program care citeşte de la tastatură un 
            şir de n numere naturale şi determină media aritmetică a 
            celor pare, n fiind citit de la tastatra
             */
            Console.WriteLine($"Introduceti numarul elementelor din sir: ");
            int totalNumbers, number;
            totalNumbers = int.Parse(Console.ReadLine());
            int sum = 0; // folosit pentru a afla cate numere pare avem
            var total = 0; //folosit pentru adunarea numerelor pare

            for (int i = 1; i <= totalNumbers; i++)
            {  
                Console.WriteLine($"Introduceti numarul: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    sum++; 
                    total=total+ number;
                }
            }
            if (sum > 0)
            {
                var mean = (decimal)total / (decimal)sum;
                Console.WriteLine($"Media artimetica a celor {sum} numere pare este: {mean}");
            }
        }
    }
}
