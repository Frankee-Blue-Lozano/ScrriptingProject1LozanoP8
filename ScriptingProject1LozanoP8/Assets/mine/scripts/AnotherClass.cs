using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int olives;
    public int crackers;

    private int paperclip;
    private int cellophane;

    // Start is called before the first frame update
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("All Fruit amount: " + answer);
    }

    // Update is called once per frame
    private void OfficeSort(int c, int d)
    {
        int answer;
        answer = c + d;
        Debug.Log("Amount of total Office Supplies: " + answer);
    }
}
