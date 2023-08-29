using System;
namespace Solution1003;
public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
       var k = new Kata(start, end);
       
       return k.CountAddress();
   }
}