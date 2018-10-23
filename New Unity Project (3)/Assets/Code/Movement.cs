using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public int cooldown = 100000;
    //public bool flips = true;
    void movement()
    {
        //int movementspeed = 4;

        //if (Input.GetKeyDown(KeyCode.LeftShift))
        //{
        //    if (flips = true && cooldown > 0)
        //    {
        //        if (cooldown == 100000)
        //        {
        //            movementspeed = 9;
        //        }
        //        cooldown = cooldown - 1;
        //        if (cooldown == 0)
        //            flips = false;
        //    }
        //    else if (flips = false && cooldown == 0)
        //    {
        //        cooldown = cooldown + 1;
        //        if (cooldown == 100000)
        //            flips = true;
        //    }

        //}
        /* if (Input.GetKeyDown(KeyCode.LeftShift))
         {
             transform.Translate(new Vector2(0, +movementspeed * Time.deltaTime));
         }*/

        int movementspeed = 4;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementspeed = 9;
        }
        else
        {
            movementspeed = 4;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -movementspeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, movementspeed * Time.deltaTime));
        }


    }

    void LateUpdate()
    {
        Vector3 tmp = Camera.main.transform.position;
        tmp.x = transform.position.x;
        tmp.y = transform.position.y;
        Camera.main.transform.position = tmp;
    }

    void Start()
    {
    }

void Update()
    {

        movement();

    }

}

