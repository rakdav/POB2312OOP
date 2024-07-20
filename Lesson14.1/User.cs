using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._1
{
    public delegate bool IsDataExists(User user);
    public class User : IUser
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get ; set ; }


        public User(string name, string password, string login)
        {
            Name = name;
            Password = password;
            Login = login;
            int idFile=0;
            bool isReal;
            using (BinaryReader reader = new BinaryReader(File.Open("userData.txt", FileMode.Open)))
            {
                isReal = false;
                while (reader.PeekChar() > -1)
                {
                    // считываем из файла строку
                    idFile = reader.ReadInt32();
                    string nameFile = reader.ReadString();
                    string loginFile = reader.ReadString();
                    if (loginFile == login)
                    {
                        Console.WriteLine("Пользователь существует");
                        isReal = true;
                        break;
                    }
                    string pass = reader.ReadString();
                }
            }
            if (isReal == false)
            {

                using (BinaryWriter writer = new BinaryWriter(File.Open("userData.txt", FileMode.OpenOrCreate)))
                {
                    writer.Write(idFile++);
                    writer.Write(Name);
                    writer.Write(Login);
                    writer.Write(Password);
                }
                Id = idFile;
            }
           
        }
    }
}
