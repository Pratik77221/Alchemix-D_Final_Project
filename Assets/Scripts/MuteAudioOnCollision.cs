using UnityEngine;

public class MuteAudioOnCollision : MonoBehaviour
{
    public AudioSource[] audioSources; 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Lever"))
        {
            
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource != null)
                {
                    audioSource.volume = 0f;
                }
            }
        }
    }
}
