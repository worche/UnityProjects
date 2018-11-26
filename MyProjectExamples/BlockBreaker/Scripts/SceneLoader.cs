using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentSceneIndex);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void StartScene()
    {
        SceneManager.LoadScene(0);

    }
}
