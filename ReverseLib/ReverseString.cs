using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLib
{
    public class ReverseString
    {
        public string Reverse(string revString)
        {
            char[] charArray = revString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}