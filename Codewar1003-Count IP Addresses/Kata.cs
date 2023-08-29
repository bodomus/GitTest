using System.Net;

namespace Solution;

public class Kata
{
    private uint[] _startIpTrio, _endIpTrio;
    
    private int[] _difference = new int[]{0, 0, 0, 0};
    private string _startAddress, _endAddress;
    public Kata(string startStr, string endStr)
    {
        _startIpTrio = startStr.Split(".").Select(s=> Convert.ToUInt32(s)).ToArray();
        _endIpTrio = endStr.Split(".").Select(s=> Convert.ToUInt32(s)).ToArray();;
        _startAddress = startStr; 
        _endAddress = endStr;
        // var i = 0;
        // if (_startIpTrio[2] > _endIpTrio[2])
        //     throw new Exception("3 element is greate.");
        // if (_startIpTrio[1] > _endIpTrio[1])
        //     throw new Exception("2 element is greate.");
        // if (_startIpTrio[0] > _endIpTrio[0])
        //     throw new Exception("1 element is greate.");
        // if (_startIpTrio[2] == _endIpTrio[2])
        //     _difference[3] = _endIpTrio[3] - _startIpTrio[3];
        // else 
        //     _difference[3] = (_endIpTrio[2] - _startIpTrio[2]) * 255 + (_endIpTrio[3] - _startIpTrio[3]);
        //
        // if (_startIpTrio[1] == _endIpTrio[1])
        // {
        //     _difference[2] = (_endIpTrio[2] - _startIpTrio[2]) * 255 + (_endIpTrio[3] - _startIpTrio[3]) ;
        // }
        // else 
        //     _difference[3] = (_endIpTrio[1] - _startIpTrio[1]) * 255 + _endIpTrio[3] - _startIpTrio[3];
        
            // _difference[i++] = Convert.ToInt32(_endIpTrio) - Convert.ToInt32(_startIpTrio);
        
    }


    public uint CountAddress()
    {
        var s = ToInt(_startAddress);
        var e = ToInt(_endAddress);
        UInt32 end = (UInt32)(256 - _endIpTrio[0]) * (256 - _endIpTrio[1]) * (256 - _endIpTrio[2]) * (256 - _endIpTrio[3]);
        uint start = (256 - _startIpTrio[0]) * (256 - _startIpTrio[1]) * (256 - _startIpTrio[2]) * (256 - _startIpTrio[3]);
        return end - start;
    }

static long ToInt(string addr)
    {
        // careful of sign extension: convert to uint first;
        // unsigned NetworkToHostOrder ought to be provided.
        return (long) (uint) IPAddress.NetworkToHostOrder(
             (int) IPAddress.Parse(addr).Address);
    }

    static string ToAddr(long address)
    {
        return IPAddress.Parse(address.ToString()).ToString();
        // This also works:
        // return new IPAddress((uint) IPAddress.HostToNetworkOrder(
        //    (int) address)).ToString();
    }


    // public Int32 Calculate()
    // {
    //     var l1 = _difference[3];
    //     
    //     return _difference[0] * 255 * 255 * 255 
    // }
}


