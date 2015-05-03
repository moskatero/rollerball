using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour
{
	public GameObject target;	// View target object
	Vector3 offset;				// Position relative to our view target
	float angle;
	void Start ()
	{
		// Compute the offset relative to our target
		offset = transform.position - target.transform.position;
	}

	void Update ()
	{



		var relativePos = transform.position - (target.transform.position);
		RaycastHit hit;
		if (Physics.Raycast (target.transform.position, relativePos,out hit, angle+0.5f)) 
		{
			Vector3 rot =  new Vector3(45f,0f,0f);
			target.transform.Rotate(rot);
		}else
		{
			transform.position = target.transform.position + offset;
		}
	}
}
