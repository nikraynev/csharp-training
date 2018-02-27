using System;
namespace Training
{
    internal class Program
    {
        public static void Main()
        {
            int minElement = 0, maxElement = 0, minIndex = 0, maxIndex = 0, sum = 0;
            
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            
            for (int I = 0; I < arrayLength; I++)
            {
                Console.Write("[{0}] = ", I);
                array[I] = int.Parse(Console.ReadLine());
                
                if (I == 0)
                {
                    maxElement = array[I];
                    minElement = array[I];
                }
                
                if (array[I] > maxElement)
                {
                    maxElement = array[I];
                    maxIndex = I;
                }
                
                if (array[I] < minElement)
                {
                    minElement = array[I];
                    minIndex = I;
                }
            }
            
            int count = Math.Abs(maxIndex - minIndex);
            int step = minIndex > maxIndex ? -1 : 1;
            
            for (int I = minIndex; I != maxIndex + step; I += step)
            {
                sum += array[I];
            }
            
            Console.Write("Medium from [{0}] to [{1}] is {2}", minIndex, maxIndex, sum / count);
        }
    }
}