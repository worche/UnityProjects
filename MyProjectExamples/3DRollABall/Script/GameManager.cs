using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public GameObject [] golds;
	private Text textscore;
	private int maxScore=13;
	private int score;
	public int Score {
		get{ return score; }
		set {
			score = value;
			if (score == maxScore) {
				textscore.text = "Bravo!!!";
			}
			else
			SetScore ();

		}
	}



	void Start () {
		golds = GameObject.FindGameObjectsWithTag ("golds");
		textscore = GameObject.Find ("Score").GetComponent<Text>();		
		score = 0;
		SetScore ();
	}


	void SetScore(){
	
		textscore.text = "Score:" + score;
	}

	public void resetle(){
		Start ();
		for(int i=0;i<golds.Length;i++)
			Destroy (golds[i]);
		Instantiate (Resources.Load("Coin"),new Vector3(45.40f,-40,1),Quaternion.identity);
	
	}
}
