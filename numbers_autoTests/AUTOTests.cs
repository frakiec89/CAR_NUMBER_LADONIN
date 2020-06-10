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
            Assert.AreEqual(AUTO.IsTryeNomberAuto("В111ФФ63"), true);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А999ГГ163"), true);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Б001ФФ01"), true);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("В111ФФ15"), true);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А594ЧЧ63"), true);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Р101РФ55"), true);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("111ФФ163"), false);
            Assert.AreEqual(AUTO.IsTryeNomberAuto(""), false);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("А9999ГГ163"), false);
         // Assert.AreEqual(AUTO.IsTryeNomberAuto("Б0F1ФФ01"), false);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("В111ФФ1555"), false);
          //  Assert.AreEqual(AUTO.IsTryeNomberAuto("А59401163"), false);
            Assert.AreEqual(AUTO.IsTryeNomberAuto("Р1PP163"), false);
            
        }


      
    }
}