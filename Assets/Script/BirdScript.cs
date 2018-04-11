//Paul Belches 17088
//Bird Script
//11/04/18
//paulbelches@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public GameObject cam; 
	float jumpForce = 500f;
	float forwardSpeed = 2f; 
	Rigidbody2D rb;
	bool dead = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!dead){
			rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed* Time.deltaTime);
			cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed* Time.deltaTime);
			if (Input.GetButtonDown("Jump")){
				rb.AddForce(new Vector2(0,1)*jumpForce);
			}
			if (rb.transform.position.x > 36.8f) {
				dead = true;
			}
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		dead = true;		
	}
}
