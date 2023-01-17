using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("COFFEE IS SO HOT THAT IT WILL MURDER YOUR MOUTH!!!1111!!");
        }

        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("COFFEE IS SO COLD THAT IT ISNT EVEN COFFEE BRO!!! DONT DRINK IT MY DUDE!!!!11!!!!1!!");
        }

        else
        {
            print("coffee is so perfect");
        }
    }
}
