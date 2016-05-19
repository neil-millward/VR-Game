using UnityEngine;
using System.Collections;

public class BulletHitReg: MonoBehaviour {
    new AudioSource audio;

    void Update()
    {
        audio = audio = GameObject.Find("DeathScream").GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other)
    {
        //if the game object is the pickup one then dissapear
        if (other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.SetActive(false);
            audio.Play();


            // print(count.ToString());
        }


    }


}
