using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    //as public, speed propertie shows up in unity
    public float speed;
   
    //Adding a Rigidbody component to an object will put its motion under the control of Unity's physics engine
    private Rigidbody rb;


    //Creating a game sound obj in unity, attaching a sound file to it then playing on collision
    new AudioSource audio;


    void Start()
    {
        //initiallised at beginning of game
        speed = 5;
        rb = GetComponent<Rigidbody>();


       
        // pickUpSound = new AudioClip(Resources.Load("Music/Super Mario Bros. - Coin Sound Effect.wav"));
        
       
    }

    void FixedUpdate()
    {
        //used to read input, "Horizontal" and "Vertical" are mapped to wasd and 360 controller woaaaaaaaaah
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    //used to set the pickup items to dissapear on collision
    void OnTriggerEnter(Collider other)
    {
        //if the game object is the pickup one then dissapear
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
           

            if (audio == null)
            {
                print("audio not found");
            }
            else
            {
                audio.Play();
            }

            // print(count.ToString());
        }


    }

  
}
