using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorComponents : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Renderer>().material.color = Color.black;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
