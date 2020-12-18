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
      Assert.AreEqual(typeof(Order), dummyOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CanReturnTargettedProperty_ProductPrice()
    {
      double testPrice = 18.99;
      Order dummy2Order = new Order("alpha", "beta", testPrice);

      Assert.AreEqual(testPrice, dummy2Order.ProductPrice);
    }

    [TestMethod]
    public void OrderConstructor_CanUpdateSavedValue_ProductDescription()
    {
      string name = "jeff";
      string descrip = "with a j";
      double price = 99.99;
      Order thirdDummy = new Order(name, descrip, price);
      string newDescrip = "or maybe with a G"; 
      thirdDummy.ProductDescription = newDescrip;
      Assert.AreEqual(thirdDummy.ProductDescription, newDescrip);
    }
  }
}