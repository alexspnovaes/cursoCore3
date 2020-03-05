using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    ref struct MyStructWithReference
    {
        public void Dispose()
        {
            Class5.IsMyStructWithReferenceDead = true;
        }
    }
    class Class5
    {
        public static bool IsMyStructWithReferenceDead { get; set; } = false;

        [Test]
        public void Class5Test()
        {
            using (var myStructWithReference = new MyStructWithReference())
            {

            }
            Assert.That(IsMyStructWithReferenceDead, Is.True);
        }
    }

}
