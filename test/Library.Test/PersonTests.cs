using NUnit.Framework;
using UnitTestAndDebug;


namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Person john = new Person("John Doe", "1.234.567-8");
        }

        [Test]
        public void validType() // Cambiá el nombre para indicar qué estás probando
        {   
            Person john = new Person("John Doe", "1.234.567-8");
            Assert.IsInstanceOf<Person>(john);

        }
                [Test]
        public void validCi() // Cambiá el nombre para indicar qué estás probando
        {   
            Person john = new Person("John Doe", "1.234.567-8");
            Assert.IsInstanceOf<Person>(john);

        }

    }
}