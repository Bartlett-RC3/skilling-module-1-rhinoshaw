using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 H O M E W O R K  A S S I G N M E N T - 1 | RC3 | AD 2020
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                                        Sai Sashank Pilla
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 */

public class Session_1_20_Sashank : MonoBehaviour
{
    // i. Declare an int variable and set a value

    public int decInt = 27;



    // ii. Declare a float variable and set a value

    public float decFloat = 2.7939393939f;



    // iii. Declare a string variable and set a value

    public string decString = "Hello RC3 World!";


    // iv. Create function that print declared Variables

    private string OPrinter(int _decInt, float _decFloat, string _decString)
    {
        string p = ("Integer:" + _decInt + "Float:" + _decFloat + "String:" + _decString);
        return p;
    }

    // v. Declare and initialize an array

    public int[] firstArray = new int[5];



    // vi. Declare and initialize a List

    public List<double> listOfDoubles = new List<double>();

    // vii. Create and initialize a Dictionary

    public Dictionary<int, string> numText = new Dictionary<int, string>
    {
        {0,"zero"},
        {1,"one"},
        {2,"Two"},
        {3,"Three"},
        {4,"Four"}
    };




    /* void Dict()
    {
        numText.Add(0,"Zero");
        numText.Add(0, "Zero");
        numText.Add(1, "One");
        numText.Add(2, "Two");
        numText.Add(3, "Three");
        numText.Add(4, "Four");
    }*/





    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(OPrinter(decInt,decFloat,decString));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
