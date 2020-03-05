using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    class MyClass
    {

    }
    class Class6
    {
        [Test]
        public void Class6Test()
        {
            string? name = null;
            MyClass? myClass = null;
        }

        [Test]
        public void Class6TestWithNullableWarnTest()
        {
#nullable enable
            string name = null;
            MyClass myClass = null;
#nullable restore
        }
    }
}
