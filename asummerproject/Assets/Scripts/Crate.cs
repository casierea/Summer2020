﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    public GameObject fracturedCrate;

    //public GameObject explosionEfect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Instantiate(explosionEfect, transform.position, Quaternion.identity);
            Instantiate(fracturedCrate, transform.position, Quaternion.identity);
            Destroy((this.gameObject));
        }
    }
}
