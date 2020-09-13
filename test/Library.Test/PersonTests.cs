using NUnit.Framework;

using UnitTestAndDebug;

using System.Linq;

using System;

namespace Tests
{
    public class Tests
    {

        private Person persona;

        [SetUp]
        public void Setup()
        {
            persona = new Person("John Doe", "1.234.567-2");
        }
        [Test]
        public void Test_Persona()
        {
            persona = new Person("John Doe", "1.234.567-2");
            Assert.IsNotNull(persona.Name);
            Assert.IsNotNull(persona.ID);
        }

        [Test]
        public void Test_Persona_Nombre_Vacio()
        {
            persona = new Person("", "1.234.567-2");
            Assert.IsNull(persona.Name);
        }

        [Test]
        public void Test_Persona_Cedula_Vacio()
        {
            persona = new Person("John Doe", "");
            Assert.IsNull(persona.ID);
        }

        [Test]
        public void Test_Persona_Vacio()
        {
            persona = new Person("", "");
            Assert.IsNull(persona.Name);
            Assert.IsNull(persona.ID);
        }

        [Test]
        public void Test_Persona_Nombre_Null()
        {
            persona = new Person(null, "1.234.567-2");
            Assert.IsNull(persona.Name);
        }       
    }
}
