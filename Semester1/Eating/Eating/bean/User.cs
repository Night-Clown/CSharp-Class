using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eating.bean
{
    class User
    {
        public int uId;
        public int uName;
        public string sex;
        public string username;
        public string password;

        public User(int uId, int uName, string sex, string username, string password)
        {
            this.uId = uId;
            this.uName = uName;
            this.sex = sex;
            this.username = username;
            this.password = password;
        }
    }
}
