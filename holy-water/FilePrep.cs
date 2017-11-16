using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace holy_water
{
    class FilePrep
    {
        public delegate int HashCode(string pw);
        public List<Bar> Read(String fileName)
        {
            List<Bar> bars = new List<Bar>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] split = line.Split('\t');
                    bars.Add(new Bar(split[0], split[1].ToDecimal(), split[3].ToDecimal(), split[4].ToDecimal(), Int32.Parse(split[2]), split[5].ToDecimal(), Int32.Parse(split[6])));
                    line = sr.ReadLine();
                }
            }
            return bars;
        }

        public void Write(String fileName, List<Bar> bars)
        {
            StreamWriter reset = new StreamWriter(fileName);
            reset.Write("");
            reset.Close();

            using (StreamWriter wr = new StreamWriter(fileName, true))
            {
                foreach (Bar bar in bars)
                {
                    wr.WriteLine(bar.Name + "\t" + bar.Volume + "\t" + bar.Percentage + "\t" + bar.LocX + "\t" + bar.LocY + "\t" + bar.Average + "\t" + bar.Count);
                }
            }
        }

        public void Write(String fileName, User user)
        {
            HashCode hash = null;
#if DEBUG
            hash += delegate (string pw)
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
                };
            };
#endif

#if DEBUG_SERVICE
            HashService.HashServiceClient client = new HashService.HashServiceClient();
            hash += delegate (string pw) { return client.HashPassword(pw); };
#endif
            using (StreamWriter wr = new StreamWriter(fileName, true))
            {
                wr.WriteLine(user.Username + "\t" + hash(user.Password));
            }
        }

        public List<User> ReadUser(String fileName)
        {
            List<User> users = new List<User>();
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] split = line.Split('\t');
                    users.Add(new User(split[0], split[1]));
                    line = sr.ReadLine();
                }
            }
            return users;
        }
    }
}
