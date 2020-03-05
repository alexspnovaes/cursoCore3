using NUnit.Framework;
using System;

namespace CSharpNewVersion
{
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime BirthDate { get; set; }

        //implementação de um método comum na própria interface
        int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    class User : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }

    [TestFixture]
    class Class1
    {
        [Test]
        public void Class1Test()
        {
            IPerson person = new Customer();
            person.BirthDate = Convert.ToDateTime("2000-01-01");

            var years = DateTime.Now.Year - person.BirthDate.Year;
            Assert.That(years, Is.EqualTo(person.GetAge()));
        }
    }
}
