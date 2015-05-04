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

	public Material materialBase;
	public Material materialFire;
	public Material materialLighting;
	public Material materialIce;

	Renderer rend;

	void Start ()
	{
		rend = GetComponent<Renderer>();
		rend.enabled = true;
		rend.material = materialBase;
		fireBall.Pause();
		fireTrail.Pause();	
		iceBall.Pause();
		icerTrail.Pause();
		lightingBall.Pause();
		lightingTrail.Pause();
	}

	void OnTriggerEnter (Collider col)  
	{
		if(col.tag == "Terrain")
		{
			ballController.canJump = true;
		}

		if(col.tag == "FireCoin")
		{
			ballController.setMoveSpeed(ballController.moveSpeed * 1.5f);
			ballController.setDrag(0.8f);
			ballController.setAngDrag(1f);
			ballController.setMass(0.8f);
			fireBall.Play();
			fireTrail.Play();	
			iceBall.Pause();
			icerTrail.Pause();
			iceBall.Clear();
			icerTrail.Clear();
			lightingBall.Pause();
			lightingTrail.Pause();
			lightingBall.Clear();
			lightingTrail.Clear();
			col.gameObject.SetActive(false);
			rend.materials[1] = materialFire;

		}
		else if (col.tag == "IceCoin")
		{
			ballController.setMoveSpeed(ballController.moveSpeed * 0.3f);
			ballController.setDrag(0.1f);
			ballController.setAngDrag(0.1f);
			ballController.setMass(0.5f);
			fireBall.Pause();
			fireBall.Clear();
			fireTrail.Pause();
			fireTrail.Clear();
			iceBall.Play();
			icerTrail.Play();
			lightingBall.Pause();
			lightingTrail.Pause();
			lightingBall.Clear();
			lightingTrail.Clear();
			col.gameObject.SetActive(false);
			rend.materials[1] = materialIce;

		}
		else if (col.tag ==  "LightingCoin")
		{
			ballController.setMoveSpeed(ballController.moveSpeed * 2f);
			ballController.setMass(0.5f);
			ballController.setDrag(1f);
			ballController.setAngDrag(1f);
			fireBall.Pause();
			fireTrail.Pause();	
			fireBall.Clear();
			fireTrail.Clear();	
			iceBall.Pause();
			icerTrail.Pause();
			iceBall.Clear();
			icerTrail.Clear();
			lightingBall.Play();
			lightingTrail.Play();
			col.gameObject.SetActive(false);
			rend.materials[1] = materialLighting;

		}
		else if (col.tag.Equals("Coin"))
		{
			ballController.setMoveSpeed(ballController.moveSpeed);
			ballController.setDrag(1f);
			ballController.setAngDrag(1f);
			ballController.setMass(1f);
			fireBall.Pause();
			fireTrail.Pause();	
			fireBall.Clear();
			fireTrail.Clear();	
			iceBall.Pause();
			icerTrail.Pause();
			iceBall.Clear();
			icerTrail.Clear();
			lightingBall.Pause();
			lightingTrail.Pause();
			lightingBall.Clear();
			lightingTrail.Clear();
			col.gameObject.SetActive(false);
			rend.materials[1] = materialBase;

		}
	}
}
