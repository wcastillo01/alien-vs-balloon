using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StopAnimation : MonoBehaviour
{
    public float life;

    void Start()
    {
        Destroy(gameObject, life);
    }
}