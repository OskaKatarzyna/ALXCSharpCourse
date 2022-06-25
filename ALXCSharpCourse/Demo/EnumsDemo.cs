using ALXCSharpCourse.Models;
using ALXCSharpCourse.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class EnumsDemo
    {
        public static void Run()
        {
            EmailMessage message = new EmailMessage
                (
                    "jankowal@wp.pl",
                    "malino@gmail.com",
                    "Sprzedam opla",
                    MessageStatus.DRAFT
                );
            message.ChangeStatus(MessageStatus.SENT);

        }
    }
}
