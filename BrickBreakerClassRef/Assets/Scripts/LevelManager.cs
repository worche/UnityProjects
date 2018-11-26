using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    [SerializeField] int breakableBlock = 0;

    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlock()
    {
        breakableBlock++;

    }

    public void BlockDestroyed()
    {
        breakableBlock--;
        if(breakableBlock <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }
}
