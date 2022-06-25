using ALXCSharpCourse.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Models
{
    public class EmailMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }

        public MessageStatus MessageStatus { get; set; }

        public EmailMessage(string from, string to, string message, MessageStatus messageStatus)
        {
            From = from;
            To = to;
            Message = message;
            MessageStatus = messageStatus;
        }

        public void ChangeStatus(MessageStatus status)
        {
            MessageStatus = status;
            Console.WriteLine($"Status change to {MessageStatus}");
        }
    }
}
