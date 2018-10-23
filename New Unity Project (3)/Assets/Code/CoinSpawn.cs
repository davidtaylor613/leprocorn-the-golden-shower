using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour {
    public GameObject Object;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPosition = GameObject.Find("playerObject").transform.position;//Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawnPosition.z = 0.0f;
            GameObject objectInstance = Instantiate(Object, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));


        }
    }
}
