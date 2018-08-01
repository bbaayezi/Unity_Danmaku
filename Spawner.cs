using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
// This class is use to spwan the bullets
// binds on an indivisual game objects (includes self and enemy)
{
	public GameObject bulletGroup;
	public GameObject parent; // used to positioning spawn point

	public enum DanmakuType
	{
		Slef,
		Round
	}

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(SpawnCoroutine());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator SpawnCoroutine()
	{
		while (true)
		{
			Instantiate(bulletGroup, parent.transform.position, Quaternion.Euler(0, 0, 0), parent.transform);
			yield return new WaitForSeconds(.06f);
		}
	}
}
