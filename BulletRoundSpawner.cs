using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRoundSpawner : MonoBehaviour 
{
	public delegate void FinishedEvent();
	public static event FinishedEvent OnSpawnFinished;
	public GameObject bullet;
	GameObject[] positioningGroup;
	public GameObject parent;
	private int frameCount = 0;
	// Use this for initialization
	void Start () 
	{
		positioningGroup = GameObject.FindGameObjectsWithTag("RoundBullets");
	}
	
	void FixedUpdate () 
	{
		// rotation
		transform.GetChild(0).transform.rotation *= Quaternion.Euler(0, 0, 1);
		
		frameCount ++;
		if (frameCount == 8)
		{ 
			Quaternion rotation = transform.GetChild(0).transform.rotation;
			// Instantiate(bullet, transform.position, rotation, parent.transform);
			Instantiate(bullet, transform.position, rotation *= Quaternion.Euler(0, 0, 15), parent.transform);
			Instantiate(bullet, transform.position, rotation *= Quaternion.Euler(0, 0, 30), parent.transform);
			Instantiate(bullet, transform.position, rotation *= Quaternion.Euler(0, 0, 45), parent.transform);
			Instantiate(bullet, transform.position, rotation *= Quaternion.Euler(0, 0, 60), parent.transform);
			Instantiate(bullet, transform.position, rotation *= Quaternion.Euler(0, 0, 75), parent.transform);
			Instantiate(bullet, transform.position, rotation *= Quaternion.Euler(0, 0, 90), parent.transform);
			if (OnSpawnFinished != null)
			{
				OnSpawnFinished();
			}
			frameCount = 0;
		}
	}
}
