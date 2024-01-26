namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //простой пример использования цикла с с постусловием do..while
            //пользователь неограниченное количество раз вводит в консоль строку
            //которая перезаписывается в переменную text
            //если введено слово "stop" то цикл завершается

            string text; 
            do
            {
                //гарантированная 1 итерация. дальнейшие зависят от условия
                text = Console.ReadLine(); 
            }
            while (text != "stop");
            Console.WriteLine("цикл остановлен");
        }
    }
}