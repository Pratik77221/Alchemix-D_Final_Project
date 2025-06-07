using UnityEngine;
using System.Collections;

public class FireToggle : MonoBehaviour
{
    public GameObject[] targetObject;  // Array of target objects to toggle
    public float toggleInterval = 1f;  // Interval between toggles

    private bool isToggled = false;

    void Start()
    {
        StartCoroutine(ToggleContinuously());
    }

    IEnumerator ToggleContinuously()
    {
        while (true)
        {
            yield return new WaitForSeconds(toggleInterval);

            // Toggle the state
            isToggled = !isToggled;

            // Iterate through the array and set each GameObject's active state
            foreach (var obj in targetObject)
            {
                if (obj != null)
                {
                    obj.SetActive(isToggled);
                }
            }
        }
    }
}
