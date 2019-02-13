using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 30f;
    public float upForce = 10.0f;

   // private CharacterController controller;
    private float verticalVelocity;
    public float gravity = 14.0f;

    public bool mLeft = false;
    public bool mRight = false;

    public bool restart = false;
    public float restartDelay = 2f;

    public static Vector3 myPlayerPosition;

    //Scene m_Scene;// Active scene

    string m_MyEndlessSceen = "Level.endless";
    string m_CurrentSceen;

    void Start()
    {
       // m_Scene = SceneManager.GetActiveScene(); // check the active Sceen/Level 

        m_CurrentSceen = SceneManager.GetActiveScene().name;
        Debug.Log(m_CurrentSceen);

    }


    // Update is called once per frame
    void FixedUpdate () {

        
        
        if(m_CurrentSceen != m_MyEndlessSceen)  // player forward movement 
        {
            myPlayerPosition = rb.position; //Player position 

            //player position
            //Debug.Log(rb.position);

            // add a forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.Force);

        }



        if (Input.GetKey("d") || mRight )// player movement to the right 
        {
            rb.AddForce(sidewaysForce* Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
            // transform.Translate(sidewaysForce * Time.deltaTime, 0, 0);
           
                
        }

        if (Input.GetKey("a") || mLeft ) //player movement to left 
        {
            rb.AddForce(-sidewaysForce*Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);  //VelocityChange
           // transform.Translate(-sidewaysForce * Time.deltaTime, 0, 0);

             
        }

        
        if (rb.position.y < -1.5f) // when player die 
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }

        

	}



    public void MoveLTrue()
    {
        mLeft = true;
    }
    public void MoveLFalse()
    {
        mLeft = false;
    }

    public void MoveRTrue()
    {
        mRight = true;
    }
    public void MoveRFalse()
    {
        mRight = false;
    }
 
  
}
