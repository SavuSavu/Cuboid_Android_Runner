using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_endl : MonoBehaviour {

    public float speed = 1f;


    void FixedUpdate()// obstacle movement 
    {

        transform.Translate(Vector3.forward * -speed* Time.deltaTime);

    }

}
