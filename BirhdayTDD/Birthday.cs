using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirhdayTDD
{
    public class Birthday
    {
        public int TotalCountFriends()
        {
            return 4;
        }
        public DateTime CheckBirthday(string Name)
        {
            return new DateTime(2018, 05, 30);
        }
    }
}
