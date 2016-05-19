using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Bullet : MonoBehaviour
{
    public Rigidbody Bullet_prefab;
    public float speed;
    new AudioSource audio;

    // float grenadeImpulse = 500f;

    // Use this for initialization
    void Start()
    {
        audio = GameObject.Find("bulletSoundSpawnPoint").GetComponent<AudioSource>();
        // Bullet_prefab = Instantiate(Bullet_prefab, Gun.transform.position, Quaternion.identity) as Rigidbody;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (audio == null)
            {
                print("audio not found");
            }
            else
            {
                audio.Play();
            }
            
            //initialisng bullet object to spawn at spawn location.
            Rigidbody instanciatedBullet_prefab = Instantiate(Bullet_prefab, transform.position, transform.rotation) as Rigidbody;

            //making the bullet move forward
            instanciatedBullet_prefab.velocity = transform.TransformDirection(new Vector3(0,0, speed));
            // print("pew pew");
        }

  
    }



}