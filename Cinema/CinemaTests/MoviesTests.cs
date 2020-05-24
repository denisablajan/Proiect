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
    public class MoviesTests
    {
        [TestMethod()]
        public void MoviesTest()
        {
            Movies movie = new Movies();
            Assert.IsNotNull(movie);
        }

        [TestMethod()]
        public void movieBtn_ClickTest()
        {
            Movies m = new Movies();
            object sender = new object();
            EventArgs e = new EventArgs();
            m.movieBtn_Click(sender, e);
            Assert.IsNotNull(m);
        }

        [TestMethod()]
        public void exitBtn_ClickTest()
        {
            Movies m = new Movies();
            object sender = new object();
            EventArgs e = new EventArgs();
            m.exitBtn_Click(sender, e);
            Assert.IsNotNull(m);
        }
    }
}