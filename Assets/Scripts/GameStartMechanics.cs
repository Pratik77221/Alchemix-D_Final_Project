using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartMechanics : MonoBehaviour
{
    public GameObject blackScreen;
    public GameObject title;
    public Animator titleAnim;
    public Animator fadeInAnim;
    void Start()
    {
        StartCoroutine(BlackToVibrant());
    }

    public IEnumerator BlackToVibrant()
    {
        yield return new WaitForSecondsRealtime(3.5f);
        fadeInAnim.SetTrigger("Fade");
        yield return new WaitForSecondsRealtime(5.0f);
        blackScreen.SetActive(false);
        title.SetActive(true);
        titleAnim.SetTrigger("Title");
        yield return new WaitForSecondsRealtime(5.0f);
        title.SetActive(false);

    }
    
    void Update()
    {
        
    }
}
