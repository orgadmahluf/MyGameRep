using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class MovementUnitTest
    {

        GameObject cube;

        [OneTimeSetUp]
        public void Init()
        {
            cube = GameObject.Instantiate(new GameObject());
            cube.AddComponent<Movement>();
        }


        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestRight()
        {
            float x = cube.transform.position.x;
            cube.GetComponent<Movement>().MovementRight();

            //We will make the move

            yield return new WaitForSeconds(0.5f); //Responsible for the time delay

            Assert.AreEqual(x + 1, cube.transform.position.x);

            //well see if it realy moves


        }
    }
}
