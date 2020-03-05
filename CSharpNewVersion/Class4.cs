using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNewVersion
{
    enum CalculationType
    {
        Sum,
        Multiply
    }
    class Class4
    {
        //funções estáticas dentro dos métodos com valores proprios
        int Calculate(int numA, int numB, CalculationType calculationType)
        {
            if (calculationType == CalculationType.Sum)
                return Sum(numA, numB);
            return Mult(numA, numB);
            static int Sum(int numA, int numB) => numA + numB;
            static int Mult(int numA, int numB) => numA * numB;
        }

        [Test]
        public void Class4Test()
        {
            var result = Calculate(10, 2, CalculationType.Sum);
            Assert.That(result, Is.EqualTo(12));

            result = Calculate(10, 2, CalculationType.Multiply);
            Assert.That(result, Is.EqualTo(20));
        }
    }
}
