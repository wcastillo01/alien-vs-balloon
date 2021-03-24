using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class green_balloon : MonoBehaviour
{
    public Text scoreboard;
    static int score = 0;

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

        if (collision.tag == "Finish")
        {
           
            Destroy(this.gameObject);
        }

        if (collision.tag == "laser")
        {
            //score += 1;
            //scoreboard.text = score.ToString();
            //scoreboard.GetComponent<Text>().text = score.ToString();
            Destroy(this.gameObject);
        }
    }
}
