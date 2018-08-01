using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfBulletController : MonoBehaviour 
{
	float bulletSpeed = .04f;
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Shooting());
		StartCoroutine(ClearBullets());
	}
	
	// Update is called once per frame
	void Update () 
	{
		// transform.position += transform.up * bulletSpeed * Time.fixedDeltaTime;
	}
	void OnBecameInvisible() 
	{
		
	}

	IEnumerator Shooting()
	{
		while(true)
		{
			transform.position += transform.up * bulletSpeed;
			yield return new WaitForSeconds(.01f);
		}
	}
	IEnumerator ClearBullets()
	{
		yield return new WaitForSeconds(2f);
		Destroy(gameObject);
		Destroy(transform.parent.gameObject);
	}
}
