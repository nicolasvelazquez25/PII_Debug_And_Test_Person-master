using NUnit.Framework;

using UnitTestAndDebug;

using System.Linq;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public bool Test_IdIsValid(string id)
        {
            long tempOut;

            // Quitar puntos y guiones
            id = id.Replace(".", "");
            id = id.Replace("-", "");

            // Validar largo
            if (id.Length == 8 && long.TryParse(id, out tempOut))
            {
                var idAsCharArray = id.ToArray();
                var idAsIntArray = idAsCharArray.Select(c => int.Parse(c.ToString())).ToArray();
                var referenceArray = "2987634".ToArray().Select(c => int.Parse(c.ToString())).ToArray();
                var inputCheckDigit = idAsIntArray[7];

                // Calcular número verificador
                int checkSum = 0;
                for (int i = 0; i < referenceArray.Length; i++)
                {
                    checkSum = checkSum + (idAsIntArray[i] * referenceArray[i]);
                }

                int checkDigit = 10 - (checkSum % 10);

                if (checkDigit == 10)
                {
                    checkDigit = 0;
                }

                if (checkDigit != inputCheckDigit)
                {
                    /// Número verificador ingresado inválido
                    return false;
                }
            }
            else
            {
                // Formato de cédula de identidad inválido
                return false;
            }

            return true;
        }
    }
}
