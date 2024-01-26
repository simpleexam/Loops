namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //простой пример использования цикла с с предусловием while
            //выводятся все четные числа от 0 до 100 в консоль
            //но при значении 50, цикл останавливается 

            int i = 0;
            while(i<100)
            {
                i++;
                if (i%2!=0)
                    continue;
                else
                    Console.WriteLine(i);
                if (i==50) break;
            }
        }
    }
}