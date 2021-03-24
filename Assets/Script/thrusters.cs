using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrusters : MonoBehaviour
{
    public GameObject ship;
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = ship.GetComponent<Rigidbody2D>();
    }
    public void GoingUp()
    {
        if (ship != null)
        {
            rb.AddForce(transform.up * 73f);
        }
        
    }
}
