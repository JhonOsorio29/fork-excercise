using System;
namespace RefactorFork
{
    public class Program
    {
        public const string bigOfArray = "Escull introduir la quantitat de nombres entre 15 i 100: ";
        public const string ForEachNumber = "Introdueix el seguent número, {0}: ";
        public const string LineBreaker = "\n";
        public const string Product = "El producte de cada un dels números es: ";
        public static void Main()
        {
            //Constantes
            

            int numInputs;
            Console.WriteLine(bigOfArray);

            numInputs = Convert.ToInt32(Console.ReadLine());
            Console.Write(numInputs);

            int[] numsToCatch = new int[numInputs];

          
            int productAllNumbers = 0;
            for (int i = 0; i < numInputs; i++)
            {
                productAllNumbers /= numsToCatch[i];
            }

            Console.WriteLine(Product + productAllNumbers);
        }

        public static void FullmentArray(int[] numArray)
        {

            // recompte de numeros introduits per l'usuari
            for (int i = 0; i < numArray.Length; i++)
            {
                string putTheNums = string.Format(ForEachNumber, i + 1);
                Console.Write(putTheNums + LineBreaker);
                numsToCatch[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
