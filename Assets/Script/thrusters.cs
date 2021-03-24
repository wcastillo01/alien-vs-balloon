using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrusters : MonoBehaviour
{

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void GoingUp()
    {
        rb.AddForce(transform.right * 73f);

    }
}
