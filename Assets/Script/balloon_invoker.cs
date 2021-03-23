using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon_invoker : MonoBehaviour
{
    public GameObject green_balloon;
    public GameObject blue_balloon ;

    void Start()
    {
        InvokeRepeating("Spawn_green_balloon", 1f, 0.5f);
        InvokeRepeating("Spawn_blue_balloon", 1f, 2f);
    }

    void Spawn_green_balloon()
    {
        Instantiate(green_balloon, transform.position, Quaternion.identity);
 
    }

    void Spawn_blue_balloon()
    {
        Instantiate(blue_balloon, transform.position, Quaternion.identity);

    }

    
}
