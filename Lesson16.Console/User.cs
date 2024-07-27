using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16.Console
{
    internal class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set;}
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime BirthDate { get; set;}

        public User(string? userName, string? firstName, string? secondName, string? email, string? password, DateTime registrationDate, DateTime birthDate)
        {
            UserName = userName;
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
            BirthDate = birthDate;
        }

        public User(int id, string? userName, string? firstName, string? secondName, string? email, string? password, DateTime registrationDate, DateTime birthDate)
        {
            Id = id;
            UserName = userName;
            FirstName = firstName;
            SecondName = secondName;
            Email = email;
            Password = password;
            RegistrationDate = registrationDate;
            BirthDate = birthDate;
        }

        public override string? ToString()
        {
            return $"{Id} {UserName} {FirstName} {SecondName} {Email} " +
                $"{Password} Дата регистрации:{RegistrationDate} Дата рождения:{BirthDate}";
        }
    }
}
