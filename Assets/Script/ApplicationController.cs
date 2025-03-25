using UnityEngine;

public class ApplicationController : MonoBehaviour
{

    public void Exit()
    {
        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
