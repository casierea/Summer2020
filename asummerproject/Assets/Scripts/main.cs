using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if space key pressed down

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key");
        }
//if e key held down
        //print
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("Holding E");
        }
        
        //if f key is lifter
        //print 

        if (Input.GetKeyUp(KeyCode.F))
        {
            Debug.Log("F Key Up");
        }
    }
}
