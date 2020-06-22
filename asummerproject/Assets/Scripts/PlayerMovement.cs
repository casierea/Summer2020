using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{[SerializeField
    ]
    private float speed;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //new vector3 (1, 0, 0) *5 * realtime. 5* 1 =5, 5*0 =,0, 5*0=0 (5,0,0)
        //transform.Translate(Vector3.right * speed * Time.deltaTime); practice
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput,0,0) * speed * Time.deltaTime);
    }
}
