using MaksimovKE_01_11.Classes;

namespace MaksimovKE_02_11
{
    [TestFixture]
    public class DogTests
    {

        //Тест проверяющий качество базового класса

        [Test]
        public void TestBaseQuantity()
        {
            DogBase dogBase = new DogBase(40, 18, 2);

            var equal = dogBase.Quantity();

            Assert.AreEqual(0.00277777778 , equal, 0.01);
        }

        //Тест проверяющий вывод информации базового класса
        [Test]
        public void TestBasePrint()
        {
            DogBase dogBase = new DogBase(40, 18, 2);

            var equal = "Рост (м) - 40\n" +
                "Вес (кг) - 18\n" +
                "Съедаемая еда в день - 2\n" +
                "Качество - 0,0027777777777777775\n";

            Assert.AreEqual(dogBase.ToString(), equal);
        }


        //Тест проверяющий качество при возарсте > 84 класса потомка
        [Test]
        public void TestDescendantQuantityFirst()
        {
            DogDescendant dogDescendat = new DogDescendant(40, 18, 2, 85);

            var equal = dogDescendat.Quantity();

            Assert.AreEqual(0.029513888888888885, equal, 0.01);
        }

        //Тест проверяющий качество при возарсте > 84 базового класса
        [Test]
        public void TestDescendantQuantitySecond()
        {
            DogDescendant dogDescendat = new DogDescendant(40, 18, 2, 65);

            var equal = dogDescendat.Quantity();

            Assert.AreEqual(0.015046296296296294, equal, 0.01);
        }

        //Тест проверяющий вывод информации класса потомка
        [Test]
        public void TestDescendantPrint()
        {
            DogDescendant dogDescendant = new DogDescendant(40, 18, 2, 85);

            var equal = "Рост (м) - 40\n" +
                "Вес (кг) - 18\n" +
                "Съедаемая еда в день - 2\n" +
                "Качество - 0,029513888888888885\n" +
                "Возраст (в месяцах) - 85";

            Assert.AreEqual(dogDescendant.ToString(), equal);
        }
    }
}