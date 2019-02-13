using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] obstaclePatterns;
   

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    public static float timer = 0.0f;
    public static int seconds = 0;

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        seconds = (int)timer % 60;
        //Debug.Log(seconds);


        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);

            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
          
            timeBtwSpawn = startTimeBtwSpawn;

            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }




    }
}
