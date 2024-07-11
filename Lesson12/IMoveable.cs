using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal interface IMoveable
    {
        const int minSpeed = 0;
        static int maxSpeed = 200;
        void Move();
        string Name { get; set; }
        delegate void MoveHandler(string message);
    }
}
