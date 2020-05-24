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
    public class Movie_infoTests
    {
        [TestMethod()]
        public void Movie_infoTest()
        {
            Movie_info info = new Movie_info(2);
            Assert.IsNotNull(info);
        }

        [TestMethod()]
        public void backtomoviesBtn_ClickTest()
        {
            Movie_info inf = new Movie_info(2);
            object sender = new object();
            EventArgs e = new EventArgs();
            inf.backtomoviesBtn_Click(sender, e);
            Assert.IsNotNull(inf);
        }
    }
}