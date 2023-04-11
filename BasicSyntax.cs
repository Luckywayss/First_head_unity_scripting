using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
void Start()
    {
        //This line is position of object x

        /* Hello.
         * This is coment by two string.
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
    }
}
