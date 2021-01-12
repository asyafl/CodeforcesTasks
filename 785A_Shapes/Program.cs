using System;

namespace _785A_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] mass = new string[n];

            for(int i =0; i<n; i++)
            {
                mass[i] = Console.ReadLine();
            }

            int count = 0;

            foreach(string caseSwitch in mass)
            {
                switch (caseSwitch)
                {
                    case "Tetrahedron":
                        count +=4;
                        break;

                    case "Cube":
                        count += 6;
                        break;

                    case "Octahedron":
                        count += 8;
                        break;

                    case "Dodecahedron":
                        count += 12;
                        break;

                    case "Icosahedron":
                        count += 20;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
