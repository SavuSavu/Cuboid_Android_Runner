using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {

    public static int numOfCoins = 0;

    void FixedUpdate()
    {



    }

    void OnTriggerEnter(Collider other)
    {

        Debug.Log("Coin Collected");
        numOfCoins++;

        Destroy(gameObject);

    }



}
