using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sales.Models;
using System.Collections.Generic;

namespace Sales.Tests
{
  [TestClass]
  public class OrderTest
  {

    [TestMethod]
    public void OrderConstructor_CreatesNewOrder_newOrder()
    {
      Order dummyOrder = new Order("dummyValue", "secondValue", 7);
      string dummyOrder2 = "bad value";
      Assert.AreEqual(typeof(Order), dummyOrder.GetType());
    }
  }
}