using holy_water.Resources;
using HolyWaterWebService;
using System;
using System.Collections.Generic;
using System.IO;

namespace holy_water
{
    class FilePrep
    {
        public delegate int HashCode(string pw);
        public List<Bar> Read(String fileName)
        {
            List<Bar> bars = new List<Bar>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
            }
            catch (FileNotFoundException ex)
            {
                using (StreamWriter wr = new StreamWriter(fileName))
                {
                }
                sr = new StreamReader(fileName);
            }
            finally
            {
                using (sr)
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] split = line.Split('\t');
                        bars.Add(new Bar(split[0], split[1].ToDecimal(), split[3].ToDecimal(), split[4].ToDecimal(), Int32.Parse(split[2]), split[5].ToDecimal(), Int32.Parse(split[6])));
                        line = sr.ReadLine();
                    }
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

        public void Write(String fileName, User user, IHashService hashClass)
        {
            List<User> users = new List<User>();
            bool match = false;
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] split = line.Split('\t');
                    users.Add(new User(split[0], split[1], (Int32.Parse(split[2]) == 1 ? true : false)));
                    line = sr.ReadLine();
                }
            }
            foreach(User u in users)
            {
                if(u.Username == user.Username)
                {
                    u.Dark = user.Dark;
                    match = true;
                }
            }
            if (match)
            {
                using (StreamWriter wr = new StreamWriter(fileName))
                {
                    foreach(User u in users)
                    {
                        wr.WriteLine(u.Username + "\t" + u.Password + "\t" + (user.Dark == true ? 1 : 0));
                    }
                }
            }
            else
            {
                using (StreamWriter wr = new StreamWriter(fileName, true))
                {
                    wr.WriteLine(user.Username + "\t" + hashClass.HashPassword(user.Password) + "\t" + (user.Dark == true ? 1 : 0));
                }
            }
        }

        public List<User> ReadUser(String fileName)
        {
            List<User> users = new List<User>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
            }
            catch(FileNotFoundException ex)
            {
                using (StreamWriter wr = new StreamWriter(fileName))
                {
                    wr.WriteLine(Resource1.BaseAdminValues);
                }
                sr = new StreamReader(fileName);
            }
            finally
            {
                using (sr)
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        string[] split = line.Split('\t');
                        users.Add(new User(split[0], split[1], (Int32.Parse(split[2]) == 1 ? false : true)));
                        line = sr.ReadLine();
                    }
                }
            }
            return users;
        }
    }
}
