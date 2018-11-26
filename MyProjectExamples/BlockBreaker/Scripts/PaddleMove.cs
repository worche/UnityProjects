using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {

    [SerializeField] float minX = 0.9f;
    [SerializeField] float maxX= 4.7f;

    [SerializeField] float ScreenWidhtInUnit = 7;
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        float mousePos = Input.mousePosition.x/Screen.width*ScreenWidhtInUnit;
        Vector2 paddlePos = new Vector2(transform.position.y, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePos, minX, maxX);
        transform.position = paddlePos;
	}
}
