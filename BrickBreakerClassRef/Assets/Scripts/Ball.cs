using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public PaddleMove paddle;

    [SerializeField] float pushX = 2f;
    [SerializeField] float pushY = 10f;

    Vector2 paddleToBallVector;
    private bool hasStarted = false;

	// Use this for initialization
	void Start () {
        paddleToBallVector = transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (hasStarted == false)
        {
            LockBall();
            LaunchOnMouseClick();
        }
	}

    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(pushX, pushY); 

        }
    }

    private void LockBall()
    {
        
            Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
            transform.position = paddlePos + paddleToBallVector;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


            float rndX = UnityEngine.Random.Range(-2f, 2f);
            float rndY = UnityEngine.Random.Range(-2f, 2f);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(rndX, rndY));
    
        
    }

}
