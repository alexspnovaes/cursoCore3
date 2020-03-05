using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CSharpNewVersion
{
    class Class8
    {
        [Test]
        public void Class8Test()
        {
            var words = new string[]
            {
                "cachorro", //^4
                "gato", //^3
                "passarinho", //^2
                "elefante" //^1
            };
            //words[^1] elefante -- começa do último pro primeiro //equivalente ao Lenght-1
            foreach(var word in words[1..2])//intervalo
            {
                Debug.WriteLine(word);
            }

            foreach (var word in words[2..^0])//intervalo até o final (qdo não se sabe o fim)
            {
                Debug.WriteLine(word);
            }

            Range range = 1..^0;

            foreach (var word in words[range])
            {
                Debug.WriteLine(word);
            }
        }
    }
}
