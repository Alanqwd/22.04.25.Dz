namespace _22._04._25.Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Person person1 = new Person("Иван Иванов", "Мужчина", 30, EyeColor.Brown);
                Person person2 = new Person("Анна Петрова", "Женщина", 25, EyeColor.Green);

                // Определяем цвет глаз их ребенка
                EyeColor childEyeColor = person1 + person2;
                Console.WriteLine($"Вероятный цвет глаз ребенка: {childEyeColor}");

                // Проверяем работоспособность
                Console.WriteLine($"{person1.FullName} работоспособен: {WorkAbility.InfoPerson(person1)}");
                Console.WriteLine($"{person2.FullName} работоспособен: {WorkAbility.InfoPerson(person2)}");
            
        }
    }
}
