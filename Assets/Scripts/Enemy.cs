﻿using UnityEngine;

public class Enemy : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
        }
    }
}