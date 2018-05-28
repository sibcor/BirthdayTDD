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
    }
}
