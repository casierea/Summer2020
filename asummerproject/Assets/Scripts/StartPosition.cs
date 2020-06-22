using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public Vector3 startPlace;
    void Start()
    {
        transform.position = startPlace;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
