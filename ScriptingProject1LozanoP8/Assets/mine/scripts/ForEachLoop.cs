using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] strings = new string[3];

        strings[0] = "FIRST STRING";
        strings[1] = "SECOND STRING";
        strings[2] = "THIRD STRING";

        foreach(string thing in strings)
        {
            print(thing);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
