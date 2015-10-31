using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_test;
using NUnit.Framework;

namespace cs_test.Test
{
    [TestFixture]
    public class WidgetTest
    {
        public class TheToStringMethod
        {
            private Widget widget;

            [SetUp]
            public void Init()
            {
                widget = new Widget();
            }

            [Test]
            public void ReturnsAnnouncement()
            {
                Assert.That(widget.ToString(), Is.EqualTo("I'm a widget!"));
            }
        }
    }
}
