using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerOcclusion : MonoBehaviour
{
    public AudioSource[] audioSource30s; 
    public AudioSource[] audioSourceOcc;
    public AudioTriggerOnPour ATOP;

    public float fadeInTime;
    public float fadeOutTime;
    

    void Start()
    {
        //for (int i = 0; i < audioSource30s.Length; i++)
        //{
        //    StartCoroutine(FadeIn(audioSource30s[i]));
        //}

        //for (int i = 0; i < audioSource30s.Length; i++)
        //{
        //    StartCoroutine(FadeOut(audioSource30s[i]));
        //}

        

    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("BC"))
        {
            Debug.Log("In Trigger");


            for (int i = 0; i < audioSource30s.Length; i++)
            {
                if (ATOP.colliderFlags[i] == true)
                {

                    StartCoroutine(FadeIn(audioSourceOcc[i]));
                    StartCoroutine(FadeOut(audioSource30s[i]));
                    
                }
            }

            //for (int i = 0; i < audioSourceOcc.Length; i++)
            //{
            //    if (ATOP.colliderFlags[i] == true)
            //    {
                   
            //    }
            //}

            

            

        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("BC"))
        {
            Debug.Log("Outside Trigger");


            for (int i = 0; i < audioSourceOcc.Length; i++)
            {
                if (ATOP.colliderFlags[i] == true)
                {
                    StartCoroutine(FadeIn(audioSource30s[i]));
                    StartCoroutine(FadeOut(audioSourceOcc[i]));
                    
                }
            }

            //for (int i = 0; i < audioSource30s.Length; i++)
            //{
            //    if (ATOP.colliderFlags[i] == true)
            //    {
                    
            //    }
            //}

            

            
        }
    }


    public IEnumerator FadeIn(AudioSource audioToBeFadedIn)
    {
        float timeElapsed = 0;
        //float start = audioToBeFadedIn.volume;

        
            while(audioToBeFadedIn.volume < 1)
            {
                audioToBeFadedIn.volume = Mathf.Lerp(0, 1, timeElapsed / fadeInTime);
                timeElapsed += Time.deltaTime;
                yield return null;
            }

        yield break;
        
    }

    public IEnumerator FadeOut(AudioSource audioToBeFadedOut)
    {
        //yield return new WaitForSecondsRealtime(15.0f);
        float timeElapsed = 0;

        while(audioToBeFadedOut.volume > 0)
        {
            audioToBeFadedOut.volume = Mathf.Lerp(1, 0, timeElapsed / fadeOutTime);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        yield break;

    }


    void Update()
    {
        
    }
}
