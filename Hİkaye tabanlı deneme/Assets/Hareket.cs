using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hareket : MonoBehaviour {

    public Camera Cam;
    public Button sagButton;
    public Button solButton;
    public Text text;
	// Use this for initialization

        void OnEnable()
    {
        sagButton.onClick.AddListener(() => değiştir());
    }
    
    void değiştir()
    {
        text.GetComponent<Text>().text = "dsdsdsddsdsds";
        Cam.GetComponent<Transform>().position = new Vector3(-500,-17,-20);
       
        Debug.Log("dwdw");
    }


	void Start () {
	
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
