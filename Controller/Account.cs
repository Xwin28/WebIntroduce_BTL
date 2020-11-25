using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebIntroduce_BTL.Controller
{
    public class Account
    {
        private String m_User;
        private String m_Password;
        private String m_Email;


        public string User { get => m_User; set => m_User = value; }
        public string Password { get => m_Password; set => m_Password = value; }
        public string Email { get => m_Email; set => m_Email = value; }
    }
}