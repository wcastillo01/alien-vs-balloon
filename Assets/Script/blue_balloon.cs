using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blue_balloon: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float random = Random.Range(-10, -1);

        transform.position = new Vector2(random, -6.12f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * 2.5f * Time.deltaTime, Space.Self);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Finish" || collision.tag == "laser")
        {
            Destroy(this.gameObject);
        }
    }
}
