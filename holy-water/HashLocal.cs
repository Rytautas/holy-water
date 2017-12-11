using HolyWaterWebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holy_water
{
    class HashLocal : IHashService
    {
        public int HashPassword(string pw)
        {
            unchecked
            {
                int hash1 = 5381;
                int hash2 = hash1;

                for (int i = 0; i < pw.Length && pw[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ pw[i];
                    if (i == pw.Length - 1 || pw[i + 1] == '\0')
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ pw[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }
    }
}
