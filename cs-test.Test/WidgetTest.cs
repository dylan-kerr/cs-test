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
        public class TheMakeWidgetMethod
        {
            private dynamic widget;

            [TestFixtureSetUp]
            public void Init()
            {
                widget = Widget.MakeWidget();
            }

            [Test]
            public void ReturnsAWidget()
            {
                Assert.That(widget, Is.TypeOf<Widget>());
            }

            [Test]
            public void ReturnsDifferentWidgetEachTime()
            {
                var secondWidget = Widget.MakeWidget();
                Assert.That(secondWidget, Is.Not.SameAs(widget));
            }
        }

        public class TheToStringMethod
        {
            private Widget widget;

            [SetUp]
            public void Init()
            {
                widget = Widget.MakeWidget();
            }

            [Test]
            public void ReturnsAnnouncement()
            {
                Assert.That(widget.ToString(), Is.EqualTo("I'm a widget!"));
            }
        }
    }
}
