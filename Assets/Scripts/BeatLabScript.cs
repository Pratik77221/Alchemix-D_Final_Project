using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatLabScript : MonoBehaviour
{
    public GameObject [] Beats;
    public AudioSource[] audios;


    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        for(int i = 0; i<Beats.Length; i++)
        {
            switch(collider.gameObject.tag)
            {
                case "B0": audios[0].Play();
                        break;

                case "B1" :
                    audios[1].Play();
                    break;

                case "B2" :
                    audios[2].Play();
                    break;

                //case 3:
                //    audios[3].Play();
                //    break;

                //case 4:
                //    audios[4].Play();
                //    break;

                //case 5:
                //    audios[5].Play();
                //    break;

                //case 6:
                //    audios[6].Play();
                //    break;

                //case 7:
                //    audios[7].Play();
                //    break;


            }
        }
    }




    void Update()
    {
        
    }
}
