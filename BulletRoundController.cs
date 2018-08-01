using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRoundController : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// transform.parent.transform.rotation *= Quaternion.Euler(0, 0, 1);
	}

	void FixedUpdate()
	{
		Shooting();
	}

	private void OnEnable() 
	{
		BulletRoundSpawner.OnSpawnFinished += NavigateBullets;
	}

	private void OnDisable() 
	{
		BulletRoundSpawner.OnSpawnFinished -= NavigateBullets;
	}

	private void NavigateBullets()
	{
		// Quaternion rotation = transform.parent.transform.rotation;
		// transform.rotation = rotation;
		// move forward
		// bullet.transform.position += new Vector3(0, -1, 0);
		// InvokeRepeating("Shooting", .06f, 0.1f);
		InvokeRepeating("ClearBullets", 8f, 8f);
	}


	void Shooting()
	{
		// transform.localPosition += new Vector3(0, 1f, 0) * Time.deltaTime;
		transform.Translate(Vector2.up * 5f * Time.fixedDeltaTime, Space.Self);
	}
	void ClearBullets()
	{
		Destroy(gameObject);
	}
}
