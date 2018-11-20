using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed;
	public float jump;
	
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grouned;
	private bool doubleJump;
	
	void Start () {
	}
	
	void FixedUpdate(){
			grouned = Physics2D.OverlapCircle (groundCheck.position,groundCheckRadius,whatIsGround);
			
	}
	
	void Update () {
		
		if(grouned)
		{
		doubleJump = false;
		}
		
		if(Input.GetKeyDown(KeyCode.W)&& grouned)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,jump);
		}
		if(Input.GetKeyDown(KeyCode.W)&& !grouned && !doubleJump)
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,jump);
		}
		if(Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed,GetComponent<Rigidbody2D> ().velocity.y);
		}
		if(Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed,GetComponent<Rigidbody2D> ().velocity.y);
		}
	}
}
