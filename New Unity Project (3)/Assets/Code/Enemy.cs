using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 1;
    public float nearEnough = 0.25f;
    public int range = 1;

    Transform tTarget;
    Transform tPlayer;
    Transform[] coin;
    Vector3 direction;
    public bool hasTarget;
    public bool wasBaited;

    // Use this for initialization
    void Start()
    {
        tPlayer = GameObject.FindGameObjectWithTag("Player").transform;
        hasTarget = false;
        wasBaited = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vPlayer = To2D(tPlayer.position);
        Vector3 vEnemy = To2D(transform.position);
        Vector3 vCoin = Vector3.zero;
        float coinDistance;
        Transform tCoin = tPlayer;

        //get player distance
        float playerDistance = Vector3.Distance(vEnemy, vPlayer);

        //set coin distance
        coinDistance = playerDistance + 1;

        //get all dropped coins and set traps
        GameObject[] coins = GameObject.FindGameObjectsWithTag("BaitCoin");
        foreach (GameObject coin in coins)
        {
            //set coin
            tCoin = coin.transform;

            //get distance for current coin
            coinDistance = Vector3.Distance(vEnemy, To2D(tCoin.position));

            //if current coin is closer than player...
            if (coinDistance < playerDistance)
            {
                //check if coin is closer than prev coin
                if (Vector3.Distance(vEnemy,To2D(tCoin.position)) > coinDistance) {
                    //if true set as new closest coin
                    tCoin = coin.transform;
                } 
            }
        }

            MoveToTarget(tCoin, tPlayer);        
    }

    void MoveToTarget(Transform coin, Transform player)
    {
        Vector3 vPlayer = To2D(player.position);
        Vector3 vEnemy = To2D(transform.position);
        Vector3 vCoin = To2D(coin.position);

        //get coin distance
        float coinDistance = Vector3.Distance(vEnemy, vCoin);

        //get player distance
        float playerDistance = Vector3.Distance(vEnemy, vPlayer);

        if(coinDistance < playerDistance)
        {
            tTarget = coin;
        } else if(playerDistance <= coinDistance)
        {
            tTarget = player;
        }

        Vector3 vTarget = To2D(tTarget.position);

        float toTarget = Vector3.Distance(vEnemy, vTarget);

        if (toTarget < range) { 
            //look at taerget
            transform.LookAt(tTarget);
                
            if (toTarget < nearEnough)
            {
                //enemy is close enough to target
                transform.position = vTarget;

                //set target flag as false
                hasTarget = false;
            }
            else
            {

                //get vector between enemy and target
                direction = vTarget - vEnemy;

                //calc velocity
                direction = direction.normalized * Time.deltaTime * speed;

                //apply velocity to current position
                transform.position += direction;
            }

        }
    }

    Vector3 To2D(Vector3 pos)
    {
        //compensate for 2d ...
        Vector3 myPos;
        myPos.x = pos.x;
        myPos.y = pos.y;
        myPos.z = 0;
        return myPos;
    }
}
