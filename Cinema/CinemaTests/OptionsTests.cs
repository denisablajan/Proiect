using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;

namespace Cinema.Tests
{
    [TestClass()]
    public class OptionsTests
    {
        [TestMethod()]
        public void OptionsTest()
        {
            Options op = new Options();
            Assert.IsNotNull(op);
        }

        [TestMethod()]
        public void login_ClickTest()
        {
            Options op = new Options();
            object sender = new object();
            EventArgs e = new EventArgs();
            op.login_Click(sender, e);
            Assert.IsNotNull(op);
        }

        [TestMethod()]
        public void movie_ClickTest()
        {
            Options op = new Options();
            object sender = new object();
            EventArgs e = new EventArgs();
            op.movie_Click(sender, e);
            Assert.IsNotNull(op);
        }
    }
}