using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TDDPractice
{
    public class Test
    {

        //[Theory]
        //[InlineData(3, "fizz")]
        //[InlineData(5, "buzz")]
        //[InlineData(10, "buzz")]
        //[InlineData(9, "fizz")]
        //[InlineData(15, "fizzbuzz")]
        //[InlineData(45, "fizzbuzz")]
        //[InlineData(7, "")]

        //public void TestingFizzBuzz(int num, string expected)
        //{
        //    //arrange
        //    FizzBuzz myFB = new FizzBuzz();
        //    string actual = myFB.GetFizzBuzz(num);

        //    //assert
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData(4, "EVEN")]
        //[InlineData(35, "ODD")]
        //[InlineData(10, "EVEN")]
        //[InlineData(41, "PRIME")]
        //[InlineData(25, "ODD")]
        //[InlineData(97, "PRIME")]
        //[InlineData(1, "PRIME")]
        //[InlineData(3, "PRIME")]
        //[InlineData(2, "PRIME")]
        //[InlineData(7919, "PRIME")]
        //[InlineData(479001599, "PRIME")]

        //public void TestingOddEvenKata(int num, string expected)
        //{
        //    //arrange
        //    OddEvenKata myOE = new OddEvenKata();
        //    string actual = myOE.OddEvenPrime(num);

        //    //assert
        //    Assert.Equal(expected, actual);
        //}

        //[Theory]
        //[InlineData("hello", false)]
        //[InlineData("Password12345", true)]
        //[InlineData("", false)]
        //[InlineData("PASSWORD12345", false)]
        //[InlineData("PasswordPassword", true)]
        //[InlineData("Hello1", true)]
        //[InlineData("12345hello", true)]
        //[InlineData("hello1", true)]

        //public void TestingPasswordVerifier(string password, bool expected)
        //{
        //    //arrange
        //    PasswordVerifier myVerifier = new PasswordVerifier();
        //    bool actual = myVerifier.Verify(password);

        //    //assert
        //    Assert.Equal(expected, actual);
        //}

        [Theory]
        [InlineData(1, "I")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(11, "XI")]
        [InlineData(14, "XIV")]
        [InlineData(40, "XL")]
        [InlineData(75, "LXXV")]
        [InlineData(105, "CV")]
        [InlineData(888, "DCCCLXXXVIII")]
        [InlineData(999, "CMXCIX")]
        [InlineData(2222, "MMCCXXII")]
        [InlineData(2008, "MMVIII")]
        [InlineData(50, "L")]

        public void TestingRomanNumerals(int num, string expected)
        {
            //arrange
            RomanNumerialsKata myRN = new RomanNumerialsKata();
            string actual = myRN.RomanNumeral(num);

            //assert
            Assert.Equal(expected, actual);
        }


    }
}
