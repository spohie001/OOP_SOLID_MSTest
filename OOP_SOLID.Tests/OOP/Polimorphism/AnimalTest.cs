using OOP_SOLID.OOP.Polimorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SOLID.Tests.OOP.Polimorphism
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void Animal_CryTriggered_CriesDifferently()
        {
            var cat = new Cat();
            var dog = new Dog();
            Assert.AreEqual("Meow", cat.Cry());
            Assert.AreEqual("Woof", dog.Cry());
        }
    }
}
