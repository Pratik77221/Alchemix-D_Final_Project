using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerOnPour : MonoBehaviour
{
    public AudioSource[] audioSources;
    public bool[] colliderFlags = { false, false, false, false, false, false, false };
    private bool fireToggle1, fireToggle2 = false;
    public bool allDone, hasRickCollided = false;
    public GameObject FireScriptGameObject;
    
    
    
    void Start()
    {
        //for(int i = 0; i< audioSources.Length; i++)
        //{
        //    audioSources[i].volume = 0;
        //}
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Bass"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}

            colliderFlags[0] = true; 
            audioSources[0].volume = 1;
            
        }

        
        if (collider.CompareTag("Kick"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}

            colliderFlags[1] = true;
            audioSources[1].volume = 1;
            fireToggle1 = true;

        }

        if (collider.CompareTag("Percussion"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}

            colliderFlags[2] = true;
            audioSources[2].volume = 1;
            fireToggle2 = true;

        }

        if (collider.CompareTag("Synth1"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}

            colliderFlags[3] = true;
            audioSources[3].volume = 1;

        }

        if (collider.CompareTag("Synth2"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}


            colliderFlags[4] = true;
            audioSources[4].volume = 1;

        }

        if (collider.CompareTag("VocalChop"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}

            colliderFlags[5] = true;
            audioSources[5].volume = 1;

        }

        if (collider.CompareTag("Keys"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}

            colliderFlags[6] = true;
            audioSources[6].volume = 1;

        }

        if (collider.CompareTag("NGGYU"))
        {
            //while (audioSources[0].volume < 1)
            //{
            //    audioSources[0].volume = Mathf.Lerp(0, 1, 2.0f);
            //}


            //audioSources[7].Play();
            hasRickCollided = true;
            

        }


    }


    void Update()
    {
        if (fireToggle1 == true || fireToggle2 == true)
        {
            FireScriptGameObject.SetActive(true);
        }


        if (colliderFlags[0] == true && colliderFlags[1] == true && colliderFlags[2] == true &&
            colliderFlags[3] == true && colliderFlags[4] == true && colliderFlags[5] == true && 
            colliderFlags[6] == true)
        {
            
            allDone = true;
        }




    }
}
