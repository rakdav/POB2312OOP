using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson16.Console
{
    public class UserRegistration
    {
        private List<User>? users;
        private const string path= "C:\\Share\\users.json";

        public UserRegistration()
        {
            this.users = new List<User>();
            ReadUsers();
        }
        private async void ReadUsers()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                try
                {
                    List<User>? userList = await JsonSerializer.DeserializeAsync<List<User>>(fs);
                    users = userList;
                }
                catch { }
            }
        }
        public bool RegisterUser(User user)
        {
            User realUser=users!.FirstOrDefault(p=>p.UserName == user.UserName&&p.Email==user.Email)!;
            if(realUser!=null)
            {
                return false;
            }
            else
            {
                user.Id = users!.Count+1;
                users.Add(user);
                SerializeUsersToJson(users, path);
                return true;
            }
        }
        public bool AuthenticateUser(string username,string password)
        {
            User realUser = users!.FirstOrDefault(p => p.UserName == username && p.Password == password)!;
            if (realUser != null) return true;
            return false;
        }
        private async void SerializeUsersToJson(List<User> users,string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, users);
            }
        }
        public string Print()
        {
            string res = "";
            foreach (User user in users!)
            {
                res+=user.Id+" "+user.FirstName+" "+user.Email+"\n";
            };
            return res;
        }
    }
}
