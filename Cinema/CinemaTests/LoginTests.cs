using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Tests
{
    [TestClass()]
    public class LoginTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            Login login = new Login();
            Assert.IsNotNull(login);
        }

        [TestMethod()]
        public void goBtn_ClickTest()
        {
            Login l = new Login();
            object sender = new object();
            EventArgs e = new EventArgs();
            l.goBtn_Click(sender, e);
            Assert.IsNotNull(l);
        }
    }
}