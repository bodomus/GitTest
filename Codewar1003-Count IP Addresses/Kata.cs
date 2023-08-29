using System.Net;

namespace Solution1003;

public class Kata
{
    private readonly string _startAddress;
    private readonly string _endAddress;

    public Kata(string startStr, string endStr)
    {
        _startAddress = startStr; 
        _endAddress = endStr;
    }

    public long CountAddress()
    {
        var s = ToInt(_startAddress);
        var e = ToInt(_endAddress);
        return e - s;
    }

static long ToInt(string addr)
    {
        return (long) (uint) IPAddress.NetworkToHostOrder(
             (int) IPAddress.Parse(addr).Address);
    }
}


