using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_behaviour : MonoBehaviour
{
    public GameObject Retry;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish")
        {
            Destroy(this.gameObject);
            Time.timeScale = 0;
            Retry.SetActive(true);
        }
    }

}