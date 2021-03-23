using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
        
    }

    public void GoingUp()
    {
        rb.AddForce(transform.right * 73f);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Finish")
        {
            Destroy(this.gameObject);
        }
    }
}
