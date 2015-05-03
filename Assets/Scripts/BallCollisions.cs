using UnityEngine;
using System.Collections;

public class BallCollisions : MonoBehaviour {


	public BallController ballController;

	public ParticleSystem fireBall;
	public ParticleSystem fireTrail;
	public ParticleSystem iceBall;
	public ParticleSystem icerTrail;
	public ParticleSystem lightingBall;
	public ParticleSystem lightingTrail;

	void Start ()
	{
		fireBall.Pause();
		fireTrail.Pause();	
		iceBall.Pause();
		icerTrail.Pause();
		lightingBall.Pause();
		lightingTrail.Pause();
	}

	void OnTriggerEnter (Collider col)  
	{

		if(col.tag.Equals("FireCoin"))
		{
			ballController.setMoveSpeed(ballController.moveSpeed * 1.5f);
			fireBall.Play();
			fireTrail.Play();	
			iceBall.Pause();
			icerTrail.Pause();
			lightingBall.Pause();
			lightingTrail.Pause();

		}
		else if (col.tag.Equals("IceCoin"))
		{
			ballController.setMoveSpeed(ballController.moveSpeed * 0.5f);
			fireBall.Pause();
			fireTrail.Pause();	
			iceBall.Play();
			icerTrail.Play();
			lightingBall.Pause();
			lightingTrail.Pause();
		}
		else if (col.tag.Equals("LightingCoin"))
		{
			ballController.setMoveSpeed(ballController.moveSpeed * 3f);
			fireBall.Pause();
			fireTrail.Pause();	
			iceBall.Pause();
			icerTrail.Pause();
			lightingBall.Play();
			lightingTrail.Play();
		}
		else if (col.tag.Equals("Coin"))
		{

		}
	}
}
