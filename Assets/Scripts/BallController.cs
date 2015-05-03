using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
	public float moveSpeed;
	public float jumpSpeed;

	private float movSpeed;
	private float jumSpeed;


	void Start ()
	{
		movSpeed = moveSpeed;
		jumSpeed = jumpSpeed;
	}

	void Update ()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		float y = 0f;
		if(Input.GetKeyDown("Space"))
		{
			y = jumpSpeed;
		}

		Vector3 force = new Vector3(x * movSpeed, y * jumSpeed, z * movSpeed);
		rigidbody.AddForce(force);
	}


	public void setMoveSpeed(float val)
	{
		movSpeed = val;
	}
	
}







