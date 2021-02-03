using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Phonebook.DataAccessLayer
{
    public class FileIO
    {
        private readonly string _path = @"C:\Users\hp\Git Repository\Week 5\Passwords.txt";
        public Dictionary<string, string> ReadPasswordFile()
        {
            try
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                string email, password;
                using (StreamReader sr = new StreamReader(_path))
                {
                    string EmailAndPswd;
                    while ((EmailAndPswd = sr.ReadLine()) != null)
                    {
                        var split = EmailAndPswd.Split("|");
                        email = split[0];
                        password = split[1];
                        result.Add(email, password);
                    }
                }
                return result;
            }
            catch 
            {
                throw new Exception("Data not found!");
            }
        }

        public void WritePasswordFile(string str)
        {
            using (StreamWriter sw = new FileInfo(_path).AppendText())
            {
                sw.WriteLine(str);
            }
        }
    }
}
