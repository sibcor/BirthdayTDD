using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirhdayTDD
{
    [TestFixture]
    public class TestDD
    {
        [Test]
        public void CreateBirthday()
        {
            Birthday birthday = new Birthday();
            Assert.NotNull(birthday);
        }
        [Test]
        public void AddBirthdayDate()
        {
            Birthday birthday = new Birthday();
            Assert.AreEqual(4, birthday.TotalCountFriends());
        }
        [Test]
        public void CheckForName()
        {
            Birthday birthday = new Birthday();
            Assert.AreEqual(new DateTime(2018, 05, 30), birthday.CheckBirthday("Petrov"));
        }
        [Test]
        public void CheckIntervalDate()
        {
            Birthday birthday = new Birthday();
            var lst = new List<Friend>();
            lst.Add(new Friend() { Name = "Ivan", Familia = "Ivanov", DT = new DateTime(2008, 12, 24) });
            Assert.AreEqual(lst[0].Name, birthday.IntervalDate(new DateTime(2008, 05, 25), new DateTime(2018, 06, 02))[0].Name);
        }
        [Test]
        public void AddBirthdayDateModifed()
        {
            Birthday birthday = new Birthday();
            Assert.AreNotEqual(5, birthday.TotalCountFriends());
        }
        [Test]
        public void ChangeBirthdayDate()
        {
            Birthday birthday = new Birthday();
            Friend friend = new Friend();
            var lst = new List<Friend>();
            Assert.AreEqual(new DateTime(2009,12,22), birthday.ChangeDate("Ivan", "Ivanov"));
        }
        [Test]
        public void CheckThrows()
        {
            Birthday birthday = new Birthday();
            Assert.Throws<ArgumentException>(() => birthday.IntervalDate(new DateTime(2028, 05, 25), new DateTime(2018, 06, 02)));
        }
    }
}
