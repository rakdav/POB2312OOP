using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14._1
{
    internal interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Login { get; set; }
    }
}
