using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Application;
using Xunit;

namespace Todo.UnitTests
{
    public class CatTest
    {
        [Fact]
        public void Cat_Tests()
        {
            var cat = new Cat();

            var mouse = new Mouse();
            cat.CatShouted += mouse.Run;

            cat.Shout();
        }
    }
}
