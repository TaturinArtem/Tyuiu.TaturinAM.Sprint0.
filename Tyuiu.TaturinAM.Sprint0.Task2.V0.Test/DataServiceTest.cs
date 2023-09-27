﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TaturinAM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.TaturinAM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Артем";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Артем", res);
        }
    }
}
