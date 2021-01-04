using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sales.Models;
using System.Collections.Generic;

namespace Sales.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod] // test 6
    public void VendorConstructor_CreatesIndividualVendor_Vendor()
    {
      Vendor dummyVendor = new Vendor("dummy vendor", "2", "3");
      Assert.AreEqual(typeof(Vendor), dummyVendor.GetType());
    }
    // end of test 6

    [TestMethod] // test 7
    public void VendorConstructor_RetrievesName_String()
    {
      string vendorName = "Bob's";
      Vendor newVendor = new Vendor(vendorName, "carol", "12");
      string test = newVendor.Name;
      Assert.AreEqual(vendorName, test);
    }
    // end of test 7
    [TestMethod] // test 8
    public void VendorConstructor_RetrievesId_Int()
    {
      string vendorName = "Carol's";
      Vendor newVendor = new Vendor(vendorName, "carol", "12");
      int resultId = newVendor.Id;

      Assert.AreEqual(1, resultId);
    }
    // end of test 8

    [TestMethod] // test 9
    public void Collect_RetrievesAllVendors_VendorList()
    {
      string test1 = "Larry's";
      string test2 = "Laurie's";
      Vendor vendor1 = new Vendor(test1, "carol", "12");
      Vendor vendor2 = new Vendor(test2, "carol", "12");
      List<Vendor> vendorList = new List<Vendor> { vendor1, vendor2 };
      List<Vendor> resultList = Vendor.GetAll();

      CollectionAssert.AreEqual(vendorList, resultList); 

    }
    // end of test 9
    [TestMethod] // test 10
    public void Lookup_RetrievesVendorById_Vendor()
    {
      string test1 = "Manny's";
      string test2 = "Maria's";
      Vendor vendor1 = new Vendor(test1, "carol", "12");
      Vendor vendor2 = new Vendor(test2, "carol", "12");
      Vendor testingId = Vendor.Find(2);
      Assert.AreEqual(vendor2.Name, testingId.Name);
    }
    // end test 10
    [TestMethod] // test 11
    public void AddOrder_TiesOrderToVendor_OrderList()
    {
      Order dummyOrder = new Order("dummy name", "dummy descrip", "999");
      List<Order> dummyList = new List<Order> { dummyOrder };
      Vendor dummyVendor = new Vendor("Julien's", "carol", "12");
      dummyVendor.AddOrder(dummyOrder);

      List<Order> testOrder = dummyVendor.Orders;

      CollectionAssert.AreEqual(dummyList, testOrder);
    }
    // end test 11
      
  }
}