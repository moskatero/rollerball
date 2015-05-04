using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
	public float moveSpeed;
	public float jumpSpeed;

	private float movSpeed;
	private float jumSpeed;
	public bool canJump;
	Vector3 cameraF;
	Vector3 cameraR;

	void Start ()
	{
		movSpeed = moveSpeed;
		jumSpeed = jumpSpeed;
	}

	void Update ()
	{
		cameraF = Camera.main.transform.forward;
		cameraR = Camera.main.transform.right;


		float x = 0f;
		float z = 0f;
		float y = 0f;

		x = Input.GetAxis ("Horizontal");
		z = Input.GetAxis ("Vertical");

		if(Input.GetKeyDown("space") && canJump)
		{
			cameraF.y = jumpSpeed;
			canJump=false;
		}
		if(Input.GetKeyDown("space"))
		{
			cameraF.x =0;
		}
		if(z == 0 )
		{
			cameraR.z =0;
		}



		GetComponent<Rigidbody>().AddForce ( cameraF.x * movSpeed, cameraF.y * jumSpeed, cameraR.z * movSpeed);
	}


	public void setMoveSpeed(float val)
	{
		movSpeed = val;
	}

	public void setDrag(float drag)
	{
		GetComponent<Rigidbody> ().drag = drag;
	}

	public void setAngDrag(float drag)
	{
		GetComponent<Rigidbody> ().angularDrag = drag;
	}

	public void setMass(float mass)
	{
		GetComponent<Rigidbody> ().mass = mass;
	}
}







