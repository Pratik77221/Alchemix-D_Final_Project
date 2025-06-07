using UnityEngine;
using UnityEngine.XR.Content.Interaction;

public class CollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BC"))
        {
            Debug.Log("Trigger collision detected with Player!");
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("BC"))
        {
            Debug.Log("Trigger colission lost");
        }
    }

}
