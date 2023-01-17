using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line tells me abt the pos of my object
        /* HEy!!!!11!!
         * This is Two lines!!Q!!!!!!111!!!1
         * */

        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm abt to die of fall damage!!! . . . lol . . DaMagE . . . couldn't be me . . . AHHHHHHHHHHHHHHHHHHHHHHHHHH!!!!11!!1!1!");
        }
    }
}
