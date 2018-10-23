using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinpikker : MonoBehaviour
{
    public int coin_counter;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "coin")
        {
                Destroy(gameObject);
        }
    }
}