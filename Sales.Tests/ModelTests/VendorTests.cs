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
      Vendor dummyVendor = new Vendor("dummy vendor");
      Assert.AreEqual(typeof(Vendor), dummyVendor.GetType());
    }
    // end of test 6

    [TestMethod] // test 7
    public void VendorConstructor_RetrievesName_String()
    {
      string vendorName = "Bob's";
      Vendor newVendor = new Vendor(vendorName);
      string test = newVendor.VendorName;
      Assert.AreEqual(vendorName, test);
    }
    // end of test 7
    [TestMethod] // test 8
    public void VendorConstructor_RetrievesID_Int()
    {
      string vendorName = "Carol's";
      Vendor newVendor = new Vendor(vendorName);
      int resultID = newVendor.ID;

      Assert.AreEqual(1, resultID);
    }
    // end of test 8

    [TestMethod] // test 9
    public void Collect_RetrievesAllVendors_VendorList()
    {
      string test1 = "Larry's";
      string test2 = "Laurie's";
      Vendor vendor1 = new Vendor(test1);
      Vendor vendor2 = new Vendor(test2);
      List<Vendor> vendorList = new List<Vendor> { vendor1, vendor2 };
      List<Vendor> resultList = Vendor.Collect();

      CollectionAssert.AreNotEqual(vendorList, resultList); 

    }
    // end of test 9
  }
}