using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{

    public AudioSource audio;
    public GameObject Stick;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "stick")
        {
            Debug.Log("Collide");
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
