using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour {
    void Look()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(
        
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y

            );

        transform.up = direction;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Look();
	}
}
