using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfBulletController : MonoBehaviour 
{
	float bulletSpeed = .04f;
	// Use this for initialization
	void Start () 
	{
		InvokeRepeating("Shooting", 0.1f, 0.01f);
		InvokeRepeating("ClearBullets", 2f, 2f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// transform.position += transform.up * bulletSpeed * Time.fixedDeltaTime;
	}

	private void FixedUpdate() 
	{
		
	}
	void OnBecameInvisible() 
	{
		
	}

	void Shooting()
	{
		transform.position += transform.up * bulletSpeed;
	}
	void ClearBullets()
	{
		Destroy(gameObject);
		Destroy(transform.parent.gameObject);
	}
}
