using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sales.Models;
using System.Collections.Generic;

namespace Sales.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
  
    [TestMethod] // test 1
    public void OrderConstructor_CreatesNewOrder_newOrder()
    {
      Order dummyOrder = new Order("dummyValue", "secondValue", 7);
      Assert.AreEqual(typeof(Order), dummyOrder.GetType());
    }
    // end of test 1

    [TestMethod] // test 2
    public void OrderConstructor_CanReturnTargettedProperty_ProductPrice()
    {
      double testPrice = 18.99;
      Order dummy2Order = new Order("alpha", "beta", testPrice);

      Assert.AreEqual(testPrice, dummy2Order.ProductPrice);
    }
    // end of test 2

    [TestMethod] // test 3
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
    // end of test 3

    [TestMethod] // test 4
    public void OrderConstructor_SetAnID_ID()
    {
      string name = "geoff";
      string descrip = "with a g";
      double price = 199.99;
      Order fourthDummy = new Order(name, descrip, price);
      Assert.AreEqual(1, fourthDummy.ID);
    }
    // end of test 4

    [TestMethod] // test 5
    public void OrderConstructor_RetrieveByID_Order()
    {
      Order test1 = new Order("name1", "description1", 17.50);
      Order test2 = new Order("name2", "description2", 27.50);
      Order test3 = new Order("name3", "description3", 37.50);
      //
      Order jimbo = Order.Lookup(0);
      Assert.AreEqual(jimbo, test1);
    }
    // end of test 5
  }
}