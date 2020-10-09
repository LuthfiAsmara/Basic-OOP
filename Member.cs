using System;
using System.Collections.Generic;
using System.Text;

namespace Pustakamedia
{
    class Member
    {
        private string name;
        private string email;

        public Member(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public string getName()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.email;
        }
    }
}
