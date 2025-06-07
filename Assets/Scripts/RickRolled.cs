using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Video;

public class RickRolled : MonoBehaviour
{
    public AudioTriggerOnPour audioTriggerOnPour;
    public GameObject lastObjPosterParent;
    public GameObject lastObject;
    public GameObject youveBeenPoster;
    public GameObject rickRolledPoster;
    public GameObject NGGYUVideo;

    public Animator videoFadeOut;

    //public GameObject[] allAudioSources;
    public GameObject cauldronAudioParent;
    public Transform mainCamera;
    float spawnDistance = 2.0f;

    void Start()
    {
       
        StartCoroutine(RickAshley());
    }

    public IEnumerator RickAshley()
    {
        yield return new WaitUntil(() =>  audioTriggerOnPour.allDone == true);
        Debug.Log("All Done");
        //yield return new WaitForSecondsRealtime(2.0f);
        lastObjPosterParent.SetActive(true);
        lastObject.SetActive(true); 
        //yield return new WaitForSecondsRealtime(5.0f);
        //lastObjPosterParent.SetActive(false);
        yield return new WaitUntil(() => audioTriggerOnPour.hasRickCollided == true);

        //for(int i = 0; i< allAudioSources.Length; i++)
        //{
        //    allAudioSources[i].SetActive(false);
        //}

        cauldronAudioParent.SetActive(false);
        yield return new WaitForSecondsRealtime(2.0f);
        
        NGGYUVideo.SetActive(true);
        yield return new WaitForSecondsRealtime(5.0f);
        youveBeenPoster.SetActive(true);
        yield return new WaitForSecondsRealtime(1.5f);
        rickRolledPoster.SetActive(true);
        videoFadeOut.SetTrigger("NGGYU");
        yield return new WaitForSecondsRealtime(9.5f);
        NGGYUVideo.GetComponentInChildren<VideoPlayer>().SetDirectAudioVolume(0, 0.7f);
        yield return new WaitForSecondsRealtime(5.0f);
        NGGYUVideo.GetComponentInChildren<VideoPlayer>().SetDirectAudioVolume(0, 0.5f);
        yield return new WaitForSecondsRealtime(2.0f);
        NGGYUVideo.GetComponentInChildren<VideoPlayer>().SetDirectAudioVolume(0, 0.2f);
        yield return new WaitForSecondsRealtime(3.0f);
        NGGYUVideo.GetComponentInChildren<VideoPlayer>().SetDirectAudioVolume(0, 0.05f);
        yield return new WaitForSecondsRealtime(4.0f);
        NGGYUVideo.SetActive(false);
        youveBeenPoster.SetActive(false);
        rickRolledPoster.SetActive(false);
        cauldronAudioParent.SetActive(true);

    }

    void Update()
    {
        if (NGGYUVideo.activeSelf)
        {
            //NGGYUVideo.transform.position = mainCamera.position + new Vector3(mainCamera.forward.x, 0, mainCamera.forward.z).normalized * spawnDistance;
            NGGYUVideo.transform.LookAt(new Vector3(mainCamera.position.x, NGGYUVideo.transform.position.y, mainCamera.position.z));
        }

        if (youveBeenPoster.activeSelf)
        {
            
           youveBeenPoster.transform.LookAt(new Vector3(mainCamera.position.x, NGGYUVideo.transform.position.y, mainCamera.position.z));
           youveBeenPoster.transform.forward *= -1;
        }


        if (rickRolledPoster.activeSelf)
        {

            rickRolledPoster.transform.LookAt(new Vector3(mainCamera.position.x, NGGYUVideo.transform.position.y, mainCamera.position.z));
            rickRolledPoster.transform.forward *= -1;
        }
    }
}
