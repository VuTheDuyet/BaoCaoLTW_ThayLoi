using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VuTheDuyet.models
{
    public static class MaHoa
    {
        public static string ToMD5(string str)
        {
            MD5 mD5 = MD5.Create();
            byte[] inputByte = System.Text.Encoding.ASCII.GetBytes(str);
            byte[] hash = mD5.ComputeHash(inputByte);
            StringBuilder sb = new StringBuilder(); 
            for( int i =0 ; i < hash.Length; i++ )
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
