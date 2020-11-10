using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 H O M E W O R K  A S S I G N M E N T - 2 | RC3 | AD 2020
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                                        Sai Sashank Pilla
 ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 */

public class Session_2_20_Sashank : MonoBehaviour
{


    [SerializeField] public int someNumber = 10;


// i. Write a function that uses a condition:

    //Function:
    // Checking if number is Prime
    public bool CheckPrime(int num)
    {
        int count = 0;



// ii. Write a for loop:

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) count++;
        }
        if (count == 2) return true;
        else return false;
    }


// iii. Write a dog class and initialize an instance of the class:
    //Class

    
    public class DogClass
    {
        //VARIBALES
        string dogName;
        string dogBreed;
        int dogAge;

        //CONSTRUCTOR
        public DogClass(string _dogName, string _dogBreed, int _dogAge)
            {
                dogName = _dogName;
                dogBreed = _dogBreed;
                dogAge = _dogAge;
            }

        //PROPERTIES (functions)
        public string getName()
            {
                return dogName;
            }
        public string getBreed()
            {
                return dogBreed;
            }
        public int getAge()
            {
                return dogAge;
            }
        public string dogProfile()
        {
            return ( " The dog goes by the name " + getName()+". " +getName()+ " is a "+getBreed()+". "+getName()+" is "+ getAge()+" years old."+ " I Love "+getName()+".");
        }


    }


    void Start()
    {       // i. Write a function that uses a condition:
            //Testing and Printing:
        if (CheckPrime(someNumber)) print("The number " + someNumber + " is a prime number");
        else print("The number " + someNumber + " is not a prime number");

        DogClass Jimmy = new DogClass("Jimmy", "Old English Bulldog", 2);
        print(Jimmy.dogProfile());
    }

    void Update()
    {
        
    }
}

