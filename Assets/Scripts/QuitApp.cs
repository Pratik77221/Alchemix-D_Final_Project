using UnityEngine;

public class QuitApp : MonoBehaviour
{
    public void QuitApplication()
    {
        Application.Quit();
        
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
