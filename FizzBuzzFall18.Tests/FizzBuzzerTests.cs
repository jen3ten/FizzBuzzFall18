using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzFall18.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        //[Test]
        //public void Foo_Test() 
        //{
        //    //Tests that true is equal to false; this is a basic test to make sure that the test process is working
        //    //Assert is a class of the NUnit Framework
        //    //the .That() method passes the actual value as the first argument and Is.EqualTo() as the second
        //    Assert.That(true, Is.EqualTo(false));

        //}

        [Test]
        public void Get_Returns_1_For_1()
        {
            //Create a FizzBuzzer class
            //Create a FizzBuzzer method
            //Assert that if you enter a '1' that a '1' is returned
            FizzBuzzer fizzBuzzer = new FizzBuzzer();

            string result = fizzBuzzer.Get(1);

            Assert.That(result, Is.EqualTo("1"));

        }
    }
}
