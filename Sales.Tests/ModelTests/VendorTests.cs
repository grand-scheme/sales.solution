using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sales.Models;
using System.Collections.Generic;

namespace Sales.Tests
{
  [TestClass]
  public class VendorTest
  {

    [TestMethod] // test 6
    public void VendorConstructor_CreatesIndividualVendor_Vendor()
    {
      Vendor dummyVendor = new Vendor("dummy vendor");
      Assert.AreEqual(typeof(Vendor), dummyVendor.GetType());
    }
    // end of test 6
  }
}