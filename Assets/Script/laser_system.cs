using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_system: MonoBehaviour
{
    public GameObject proyectile;
    public GameObject ship;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Instantiate(proyectile, ship.transform.position, Quaternion.identity);
        }

    }

    public void Shoot()
    {
        if (ship != null)
            Instantiate(proyectile, ship.transform.position, Quaternion.identity);
    }
}
