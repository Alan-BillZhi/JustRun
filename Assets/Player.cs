using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private float jumpForce = 15;
	private float gravity = 1.5f;
	private float speed = 0;
	private float ground = 0;

	private bool isJumping = false;
	// Use this for initialization
	void Start () {
		ground = transform.position.y;
	}

	// Update is called once per frame
	void Update () {
		if(isJumping){
			transform.position += new Vector3(0, speed * Time.deltaTime, 0);
			speed -= gravity;

			if(transform.position.y <= ground){
				transform.position += new Vector3(0, ground - transform.position.y, 0);
				isJumping = false;
			}
		}
	}

	public void Jump(){
		if(!isJumping){
			speed = jumpForce;
			isJumping = true;
		}
	}
}
