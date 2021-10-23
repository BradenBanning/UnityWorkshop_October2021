using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    //private hides variables in the inspector.
    private int _height = 10;
    //public shows variables in the inspector.
    public float Width = 15.5f;
    //SerialzieField shows private variables in the inspector.
    [SerializeField] private string _name = "MyHouse";
    //A vector 3 contains 3 floats. An X, Y, and Z.
    [SerializeField] private Vector3 _dimensions;
    //A Bool is a value that is true or false.
    [SerializeField] private bool _isUnderConstruction = true;
    
    // Start is called before the first frame update
    void Start()
    {
        //Setting the _dimenstions, based on Width and _height.
        //Note: a Vector3, can ignore z.
        _dimensions = new Vector3(Width, _height);
        //Debug.Log() prints to the console.
        Debug.Log(_dimensions);


        
        
    }  

    // Update is called once per frame
    void Update()
    {
        //if checks what's inside its "()" and if it is true, 
        //then execute the code inside of the following "{}"
        if (_isUnderConstruction == true)
        {
            //if the _isUnderConstruction is true, print it to the Console.
            Debug.Log("House is under construction.");
        }
        //An else checks the above "if", and if it's false, then it executes code inside the "else".
        else
        {
            //if the _underConstruction is false, print it to the Console.
            Debug.Log("House is not under construction.");
        }

        Debug.Log("Update!");
    }

    //FixedUpdate updates every "Physics Tick", which means every set time period.
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate!");
    }


}
