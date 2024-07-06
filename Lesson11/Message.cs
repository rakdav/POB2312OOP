using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Messanger<T> where T : Message
    {
        public void SendMessage<T>(T mes) where T : Message
        {
            Console.WriteLine($"Отправляется сообщение: {mes.Text}");
        }
    }
    internal class Message
    {
        public string Text { get; }
        public Message(string text)
        {
            Text = text;
        }
    }
    internal class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text){}
    }
    internal class SmsMessage : Message
    {
        public SmsMessage(string text) : base(text){}
    }
}
