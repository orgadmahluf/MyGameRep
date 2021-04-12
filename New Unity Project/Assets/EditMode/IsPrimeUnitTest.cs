using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class IsPrimeUnitTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void Sanity()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(true, Main.IsPrime(13));
        }

        [Test]
        public void CheckNotPrime()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(true, Main.IsPrime(9));
        }

        [Test]
        public void CheckError()
        {
            // Use the Assert class to test conditions
            Assert.AreEqual(true, Main.IsPrime(-9));
        }




    }
}
