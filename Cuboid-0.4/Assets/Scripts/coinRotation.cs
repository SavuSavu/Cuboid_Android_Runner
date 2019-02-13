using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinRotation : MonoBehaviour {

    public int rotateSpeed = 1;
    public float speed = 1f;


    // Update is called once per frame
    void FixedUpdate() {

        transform.Rotate(0, rotateSpeed * Time.fixedDeltaTime, 0 );// rotation    ,Space.World
        transform.Translate(Vector3.up * -speed * Time.deltaTime); // movement 

        
    }
}
