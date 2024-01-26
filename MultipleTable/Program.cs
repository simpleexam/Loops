namespace MultipleTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вывыод таблицы умножения с помощью всех трех типов циклов
            //в каждом способе используются вложенные циклы

            Console.WriteLine("таблица умножения через цикл с параметром");
            //таблица умножения через цикл с параметром
            for (int ii = 2; ii <10; ii++)
            {
                for (int jj = 1; jj<10; jj++)
                {
                    Console.WriteLine($"{ii} * {jj} = {ii*jj}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("таблица умножения через цикл с предусловием") ;
            //таблица умножения через цикл с предусловием
            int i = 1;
            while (i < 10)
            {
                int j = 1;
                while (j < 10)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                    j++;
                }
                i++;
                Console.WriteLine();
            }

            Console.WriteLine("таблица умножения через цикл с постусловием");
            //таблица умножения через цикл с постусловием
            i = 1;
            do
            {
                int j = 1;
                do
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                    j++;
                }
                while (j<10);
                Console.WriteLine();
                i++;
            }
            while (i<10);
        }
    }
}