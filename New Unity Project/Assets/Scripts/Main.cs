using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
   public static bool IsPrime(int num)
    {
        if (num < 0) throw new System.ArithmeticException("negative!!!");
        for(int i=2; i<num ; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}
