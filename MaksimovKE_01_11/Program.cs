using MaksimovKE_01_11.Classes;

try
{   
    // Переменные
    double height, weight, foodEaten, age;
    int choice;
    // список для хранения информации
    List<DogBase> dogBaseList = new List<DogBase>();
    List<DogDescendant> dogDescendantList = new List<DogDescendant>();
    // Объявление классов
    DogBase dogBase = new DogBase();
    DogDescendant dogDescendant = new DogDescendant();

    // метод добавления информации базового класса
    void AddDogBase()
    {
        Console.Write("Введите рост (м): ");
        height = double.Parse(Console.ReadLine());

        Console.Write("Введите вес (кг): ");
        weight = double.Parse(Console.ReadLine());

        Console.Write("Введите кол-во съедаемой еды (кг): ");
        foodEaten = double.Parse(Console.ReadLine());
    }

    // метод добавления информации класса потомка
    void AddDogDescendant()
    {
        Console.Write("Введите рост (м): ");
        height = double.Parse(Console.ReadLine());

        Console.Write("Введите вес (кг): ");
        weight = double.Parse(Console.ReadLine());

        Console.Write("Введите кол-во съедаемой еды (кг): ");
        foodEaten = double.Parse(Console.ReadLine());

        Console.Write("Введите возраст (в месяцах): ");
        age = double.Parse(Console.ReadLine());
    }

    while (true)
    {
        Console.WriteLine("1. Добавить информацию в базовый класс\n" +
            "2. Добавить информацию в класс потомок\n" +
            "3. Вывести список всех данных из базого класса\n" +
            "4. Вывести список всех данных из класса потомка\n" +
            "5. Выход.");

        Console.Write("Введите номер действия: ");
        choice = int.Parse(Console.ReadLine());
        

        switch (choice)
        {
            case 1:
                AddDogBase();
                dogBase = new DogBase(height, weight, foodEaten);
                dogBaseList.Add(dogBase);
                Console.WriteLine("Информация добавлена успена!\n");
                break;
            case 2:
                AddDogDescendant(); 
                dogDescendant = new DogDescendant(height, weight, foodEaten, age);
                dogDescendantList.Add(dogDescendant);
                Console.WriteLine("Информация добавлена успена!\n");
                break;
            case 3:
                foreach (var item in dogBaseList)
                {
                    Console.WriteLine(item.ToString());
                }
                break;
            case 4:
                foreach (var item in dogDescendantList)
                {
                    Console.WriteLine(item.ToString());
                }
                break;
            case 5:
                Console.WriteLine("До новых встреч!");
                return 0;
            default:
                Console.WriteLine("Такого действия нет");
                break;
        }
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

