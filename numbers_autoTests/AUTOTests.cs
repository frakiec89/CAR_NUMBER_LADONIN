using Microsoft.VisualStudio.TestTools.UnitTesting;
using numbers_auto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers_auto.Tests
{
    [TestClass()]
    public class AUTOTests
    {
        [TestMethod()]
        public void IsTryeNomberAutoTest()
        {
              Assert.AreEqual( AUTO.IsTryeNomberAuto("А111ФФ163"), true);
        }


        [TestMethod()]
        public void IsTryeNomberAutoTest1 ()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("В111ФФ63"), true);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest2()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А999ГГ163"), true);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest3()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Б001ФФ01"), true);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest4()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("В111ФФ15"), true);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest5()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А594ЧЧ63"), true);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest6()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Р101РФ55"), true);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest7()
        { 
            Assert.AreEqual(AUTO.IsTryeNomberAuto("111ФФ163"), false);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest8()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А9999ГГ163"), false);
        }


        [TestMethod()]
        public void IsTryeNomberAutoTest9()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("В111ФФ1555"), false);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest10()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Р1PP163"), false);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest11()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Б0F1ФФ01"), false);
        }

        [TestMethod()]
        public void IsTryeNomberAutoTest12 ()
        {
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А59401163"), false);
        }

    }
}