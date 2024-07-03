namespace MaksimovKE_01_11.Classes
{
    public class DogDescendant : DogBase
    {
        //Поле возраст в месяцах
        private double age;

        public double Age
        {
            get { return age; }
            set { age = value; }
        }

        public DogDescendant()
        {
            
        }
        public DogDescendant(double height, double weight, double foodEaten, double age) : base(height, weight, foodEaten)
        {
            Height = height;
            Weight = weight;
            FoodEaten = foodEaten;
            Age = age;
        }
        //Метод подсчёта качества объекта
        public override double Quantity()
        {
            double baseQuantity = base.Quantity();

            if (age < 84)
            {
                return baseQuantity * age / 12;
            }
            else return baseQuantity * age / 8;
        }
        //Метод вывода информации
        public override string ToString()
        {
            return base.ToString() + $"Возраст (в месяцах) - {Age}";
        }

    }
}
