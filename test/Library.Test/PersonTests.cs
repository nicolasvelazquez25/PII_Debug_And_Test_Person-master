using NUnit.Framework;

using UnitTestAndDebug;

using System.Linq;

namespace Tests
{
    public class Tests
    {

        private Person persona;

        private Person persona_nombre_vacio;

        private Person persona_cedula_vacio;

        private Person persona_vacio;

        private Person persona_nombre_null;

        private Person persona_cedula_null;

        private Person persona_null;

        [SetUp]
        public void Setup()
        {
            persona = new Person("John Doe", "1.234.567-8");
            persona_nombre_vacio = new Person("", "1.234.567-8");
            persona_cedula_vacio = new Person("John Doe", "");
            persona_vacio = new Person("", "");
            persona_nombre_null = new Person(null, "1.234.567-8");
            persona_cedula_null = new Person("John Doe", null);
            persona_null = new Person(null, null);
        }

        [Test]
        public void Test_Isvalid_True()
        {
            bool result = IdUtils.IdIsValid("1.234.567-8");
            Assert.AreEqual(true, result);
        }

        public void Test_Isvalid_Sin_Puntos()
        {
            bool result = IdUtils.IdIsValid("12345678");
            Assert.AreEqual(true, result);
        }

        public void Test_Isvalid_Exceso()
        {
            bool result = IdUtils.IdIsValid("1.234.567-80");
            Assert.AreEqual(false, result);
        }
        public void Test_Isvalid_Falta()
        {
            bool result = IdUtils.IdIsValid("1.234.567-");
            Assert.AreEqual(false, result);
        }
        public void Test_Isvalid_Vacio()
        {
            bool result = IdUtils.IdIsValid("");
            Assert.AreEqual(false, result);
        }
        public void Test_Isvalid_Null()
        {
            bool result = IdUtils.IdIsValid(null);
            Assert.AreEqual(false, result);
        }
        public void Test_Persona()
        {
            Person result = new Person("John Doe", "1.234.567-8");
            Assert.AreEqual(persona, result);
        }
        public void Test_Persona_Nombre_Vacio()
        {
            Person result = new Person("", "1.234.567-8");
            Assert.AreEqual(persona_nombre_vacio, result);
        }
        public void Test_Persona_Cedula_Vacio()
        {
            Person result = new Person("John Doe", "");
            Assert.AreEqual(persona_cedula_vacio, result);
        }
        public void Test_Persona_Vacio()
        {
            Person result = new Person("", "");
            Assert.AreEqual(persona_vacio, result);
        }
        public void Test_Persona_Nombre_Null()
        {
            Person result = new Person(null, "1.234.567-8");
            Assert.AreEqual(persona_nombre_null, result);
        }
        public void Test_Persona_Cedula_Null()
        {
            Person result = new Person("John Doe", null);
            Assert.AreEqual(persona_cedula_null, result);
        }
        public void Test_Persona_Null()
        {
            Person result = new Person(null, null);
            Assert.AreEqual(persona_null, result);
        }
    }
}
