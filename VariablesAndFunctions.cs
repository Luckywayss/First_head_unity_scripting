using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MultiplyByTwo(myInt));
    }

    int MultiplyByTwo(int number)
    {
        int result = 0;
        result = number * 2;
        return result;
    }
}
