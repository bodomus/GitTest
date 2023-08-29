using NUnit.Framework;
using System;
namespace Solution1003;
public class CountIPAddressesTest
{
    [Test]
    public void SmapleTest()
    {
        Assert.AreEqual(50, CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
        Assert.AreEqual(246, CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
        Assert.AreEqual((1L << 32) - 1L, CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));
    }
}