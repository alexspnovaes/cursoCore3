using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpNewVersion
{
    class MyFile : StreamWriter
    {
        public bool IsDead { get; set; } = false;
        public MyFile(string path) : base(path)
        {

        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            IsDead = true;
        }
    }
    class Class3
    {
        private MyFile myFile;

        private void WriteLines(IEnumerable<string> lines)
        {
            //não precisa mais usar o using no contexto
            using var file = new MyFile("test.txt");

            foreach (var line in lines)
            {
                file.WriteLine(line);
            }

            myFile = file;
        }
        [Test]
        public void Class3Test()
        {
            WriteLines(new string[] {
                "Informática",
                "Computador",
                "Programação"
            });

            Assert.That(myFile.IsDead, Is.True);
        }
    }
}
