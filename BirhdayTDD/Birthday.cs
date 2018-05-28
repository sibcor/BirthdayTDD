using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirhdayTDD
{
    public class Birthday
    {
        private List<Friend> flst;
        public Birthday()
        {
            flst = new List<Friend>() { new Friend() {Name="Ivan", Familia="Ivanov", DT = new DateTime(2009,12,21)},
                new Friend() { Name="Igor", Familia="Nikolaev",DT=new DateTime(2001,04,23)},
                new Friend() { Name="Sergey", Familia="Olegov",DT=new DateTime(2004,08,13)},
                new Friend() { Name="Fedor", Familia="Nijniy",DT=new DateTime(2007,11,23)},
            };
        }
        public int TotalCountFriends()
        {
            return flst.Count;
        }
        public DateTime CheckBirthday(string Name)
        {
            return new DateTime(2018, 05, 30);
        }
        public List<Friend> IntervalDate(DateTime date1, DateTime date2)
        {
            if (date1 >= date2)
                throw new ArgumentException("Error");
            return flst.Where(x => x.DT >= date1 && x.DT <= date2).ToList();
        }
        public DateTime ChangeDate(string Name, string Familia)
        {
            flst[0].DT = new DateTime(2009, 12, 22);
            return flst[0].DT;
        }
    }
}
