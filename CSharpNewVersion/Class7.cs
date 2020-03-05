using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNewVersion
{
    class Class7
    {
        public async IAsyncEnumerable<int> GetNumbers()
        {
            for (int i =1; i<=20; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        [Test]
        public async Task  Class7Test()
        {
            await foreach(var number in GetNumbers())
            {
                Debug.WriteLine(number);
            }
        }
    }
}
