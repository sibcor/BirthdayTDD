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
    }
}
