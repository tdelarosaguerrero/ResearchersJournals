using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ResearchersJournals.Web.Utils
{
    public class Utils
    {
        public static String GenerarHashSHA256(String value)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(value));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash) stringBuilder.AppendFormat("{0:x2}", b);
            return stringBuilder.ToString();
        }
    }
}
