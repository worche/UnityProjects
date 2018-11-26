using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {



    [Range(0.1f,5f)][SerializeField] float gameSpeed = 1f;

    [SerializeField] int scorePerBlock = 27;

    int currentScore = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Time.timeScale = gameSpeed;
	}
    public void AddToScore()
    {
        currentScore = currentScore + scorePerBlock;
    }
}
