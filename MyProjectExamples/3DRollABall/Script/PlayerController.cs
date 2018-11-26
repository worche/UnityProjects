using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public GameManager GM;
	public float speed;
	public float power;
	public Rigidbody rb;
	public GameObject Yer;
	// Use this for initialization
	void Start () {
		GM = GameObject.FindObjectOfType<GameManager>();
		power = 350f;
		Yer = GameObject.Find ("Ground");
		rb = GetComponent<Rigidbody>();
		speed = 20;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		float veritcal = Input.GetAxis ("Vertical");


		Vector3 dir = new Vector3 (horizontal, 0, veritcal);
		rb.AddForce (dir * speed);

		if (Input.GetKeyDown (KeyCode.Space)&& transform.position.y<=1.5f && transform.position.y >1.4f)
			rb.AddForce (Vector3.up * power); 

		//transform.Translate((new Vector3(horizontal,0,veritcal)); 

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject == Yer) {
			transform.position = new Vector3 (0, 2, -16);
			rb.Sleep ();
			GM.resetle();
		} else {

			Destroy (other.gameObject);
			GM.Score++;
		}
    }

}
