using MaksimovKE_01_11.Classes;

namespace MaksimovKE_02_11
{
    [TestFixture]
    public class DogTests
    {

        //���� ����������� �������� �������� ������

        [Test]
        public void TestBaseQuantity()
        {
            DogBase dogBase = new DogBase(40, 18, 2);

            var equal = dogBase.Quantity();

            Assert.AreEqual(0.00277777778 , equal, 0.01);
        }

        //���� ����������� ����� ���������� �������� ������
        [Test]
        public void TestBasePrint()
        {
            DogBase dogBase = new DogBase(40, 18, 2);

            var equal = "���� (�) - 40\n" +
                "��� (��) - 18\n" +
                "��������� ��� � ���� - 2\n" +
                "�������� - 0,0027777777777777775\n";

            Assert.AreEqual(dogBase.ToString(), equal);
        }


        //���� ����������� �������� ��� �������� > 84 ������ �������
        [Test]
        public void TestDescendantQuantityFirst()
        {
            DogDescendant dogDescendat = new DogDescendant(40, 18, 2, 85);

            var equal = dogDescendat.Quantity();

            Assert.AreEqual(0.029513888888888885, equal, 0.01);
        }

        //���� ����������� �������� ��� �������� > 84 �������� ������
        [Test]
        public void TestDescendantQuantitySecond()
        {
            DogDescendant dogDescendat = new DogDescendant(40, 18, 2, 65);

            var equal = dogDescendat.Quantity();

            Assert.AreEqual(0.015046296296296294, equal, 0.01);
        }

        //���� ����������� ����� ���������� ������ �������
        [Test]
        public void TestDescendantPrint()
        {
            DogDescendant dogDescendant = new DogDescendant(40, 18, 2, 85);

            var equal = "���� (�) - 40\n" +
                "��� (��) - 18\n" +
                "��������� ��� � ���� - 2\n" +
                "�������� - 0,029513888888888885\n" +
                "������� (� �������) - 85";

            Assert.AreEqual(dogDescendant.ToString(), equal);
        }
    }
}