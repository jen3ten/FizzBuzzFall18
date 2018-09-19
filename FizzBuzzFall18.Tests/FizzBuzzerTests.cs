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

        FizzBuzzer fizzBuzzer;

        [SetUp]
        public void SetUp()
        {
            //FizzBuzzer fizzBuzzer = new FizzBuzzer();
            //^ When fizzBuzzer object was declared in SetUp() we couldn't use it out of scope
            //^ We moved the declaration outside of this method, to the class
            fizzBuzzer = new FizzBuzzer();
        }

        [Test]
        public void Get_Returns_1_For_1()
        {
            //Create a FizzBuzzer class
            //Create a FizzBuzzer method
            //Assert that if you enter a '1' that a '1' is returned
            
            //FizzBuzzer fizzBuzzer = new FizzBuzzer();
            //^ We moved this to SetUp()

            string result = fizzBuzzer.Get(1);

            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void Get_Returns_2_For_2()
        {
            //Assert that if you enter a '2' that a '2' is returned

            //FizzBuzzer fizzBuzzer = new FizzBuzzer();
            //^ We moved this to SetUp()

            string result = fizzBuzzer.Get(2);

            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void Get_Returns_Fizz_For_3()
        {
            //Assert that if you enter '3' that "Fizz" is returned

            //FizzBuzzer fizzBuzzer = new FizzBuzzer();
            //^ We moved this to SetUp()

            string result = fizzBuzzer.Get(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        public void Get_Returns_Expected(int input, string output)
        {
            string result = fizzBuzzer.Get(input);

            Assert.That(result, Is.EqualTo(output));
        }
    }
}
