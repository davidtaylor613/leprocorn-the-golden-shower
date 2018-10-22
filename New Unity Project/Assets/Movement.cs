using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    void movement()
    {
        float movementspeed = 4.5f;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementspeed = 9.0f;
        }
        else
        {
            movementspeed = 4.5f;
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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        movement();

    }

    void LateUpdate()
    {
        Vector3 tmp = Camera.main.transform.position;
        tmp.x = transform.position.x;
        tmp.y = transform.position.y;
        Camera.main.transform.position = tmp;
    }
}
