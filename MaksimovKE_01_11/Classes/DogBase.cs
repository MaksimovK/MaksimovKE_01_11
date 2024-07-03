namespace MaksimovKE_01_11.Classes
{
    public class DogBase
    {
        //поле рост м
        private double height;

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

        //поле вес кг
		private double weight;

		public double Weight
        {
			get { return weight; }
			set { weight = value; }
		}

        //поле кол-во съедаемой еды кг
		private double foodEaten;

		public double FoodEaten
        {
			get { return foodEaten; }
			set { foodEaten = value; }
		}
        public DogBase()
        {
            
        }
        public DogBase(double height, double weight, double foodEaten)
		{
			Height = height;
			Weight = weight;
			FoodEaten = foodEaten;
		}
        //Метод подсчёта качества объекта
        public virtual double Quantity()
		{
			return foodEaten / weight / height; 
		}
        //Метод вывода информации
        public override string ToString() 
		{
			return $"Рост (м) - {height}\n" +
				$"Вес (кг) - {weight}\n" +
				$"Съедаемая еда в день - {foodEaten}\n" +
				$"Качество - {Quantity()}\n";
        }
	}
}
