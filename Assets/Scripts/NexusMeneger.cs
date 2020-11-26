﻿using UnityEngine;
using UnityEngine.UI;

public class NexusMeneger : MonoBehaviour
{
    public Text mytext;
    public GameObject lose;
    int hp = 20;

    void Start()
    {
        mytext.text = "NEXUS HEALTH:" + hp;
    }

    void Update()
    {
        if (hp == 0)
        {
            //Debug.Log("You're looser");
            lose.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            hp--;
            mytext.text = "NEXUS HEALTH:" + hp;
            Debug.Log("Kolizja z nexusem");
        }
    }
}
