using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Model
{
    class User
    {
        string userID, password;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }


    }
}
