using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Prueba;
using System.IO;

namespace LibreriaProbar
{
    [TestFixture]
    public class LibreriaProbar
    {
        //Archivo
        [Test]
        public void ArchivoStringEqual()
        {
            Probar objPrueba = new Probar();
            string read = File.ReadAllText(" @C:\Users\vIN\.jenkins\workspace\TA2File\Prueba\Archivo.txt", Encoding.UTF8);
            Assert.IsTrue(objPrueba.CompararIguales(read,"Hola"));
        }
        //Valores Iguales
        [Test]
        public void TestSumaEqual()
        {
            Probar objPrueba = new Probar();
            Assert.AreEqual(9, objPrueba.Suma(8, 1));
        }

        [Test]
        public void TestUnirEqual()
        {
            Probar objPrueba = new Probar();
            Assert.AreEqual("Don Ian", objPrueba.Unir("Don ", "Ian"));
        }


        //Valores Distintos
        [Test]
        public void TestSumaNotEqual()
        {
            Probar objPrueba = new Probar();
            Assert.AreNotEqual(9, objPrueba.Suma(1, 2));
        }

        [Test]
        public void TestUnirNotEqual()
        {
            Probar objPrueba = new Probar();
            Assert.AreNotEqual("Don Ian", objPrueba.Unir("No", "Ian"));
        }

        //Valores Nulos
        [Test]
        public void TestUnirNull()
        {
            Probar objPrueba = new Probar();
            Assert.IsNull(objPrueba.Unir(null, null));
        }

        //Boolean
        [Test]
        public void TestBoolTrue()
        {
            Probar objPrueba = new Probar();
            Assert.IsTrue(objPrueba.CompararIguales("Igual", "Igual"));
        }

        [Test]
        public void TestBoolFalse()
        {
            Probar objPrueba = new Probar();
            Assert.IsFalse(objPrueba.CompararIguales("Igual", "Igul"));
        }
    }
}
