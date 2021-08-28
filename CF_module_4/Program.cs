using System;

namespace CF_module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string[] dishes) User;
            Console.Write("Введите имя пользователя: ");
            User.name = Console.ReadLine();
            User.dishes = new string[4];
            Console.WriteLine("Введите любимые блюда:");
            for (int i = 0; i < User.dishes.Length; i++)
            {
                User.dishes[i] = Console.ReadLine();
            }
            Console.WriteLine("Ваши любимые блюда: ");
            foreach(string dish in User.dishes)
            {
                Console.WriteLine(dish);
            }
        }
    }
}
