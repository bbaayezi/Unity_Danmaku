using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour 
{

	public GameObject sprite;
	public float moveSpeed;
	private float m_MovementInput;
	private float m_TurnInput;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		HandleMovement();
	}

	void HandleMovement()
	{
		Vector3 movement = Vector3.zero;
		// vertical
		m_MovementInput = Input.GetAxis("Vertical");
		m_TurnInput = Input.GetAxis("Horizontal");
		if (m_TurnInput < 0.1f && m_TurnInput > -0.1f)
		{
			if (m_MovementInput > 0.1f)
			{
				movement = transform.up * moveSpeed * Time.deltaTime;
			}
			else if (m_MovementInput < -0.1f)
			{
				movement = -transform.up * moveSpeed * Time.deltaTime;
			}
			
		}
		else if (m_MovementInput < 0.1f && m_MovementInput > -0.1f)
		{
			if (m_TurnInput > 0.1f)
			{
				movement = transform.right * moveSpeed * Time.deltaTime;
			}
			else if (m_TurnInput < -0.1f)
			{
				movement = -transform.right * moveSpeed * Time.deltaTime;
			}
		}
		else
		{
			if (m_TurnInput > 0.1f && m_MovementInput > 0.1f)
			{
				movement = (transform.right + transform.up) * moveSpeed * Time.deltaTime;
			}
			else if (m_TurnInput > 0.1f && m_MovementInput < -0.1f)
			{
				movement = (transform.right - transform.up) * moveSpeed * Time.deltaTime;
			}
			else if (m_TurnInput < -0.1f && m_MovementInput > 0.1f)
			{
				movement = (transform.up - transform.right) * moveSpeed * Time.deltaTime;
			}
			else if (m_TurnInput < -0.1f && m_MovementInput < -0.1f)
			{
				movement = (-transform.up - transform.right) * moveSpeed * Time.deltaTime;
			}

		}
		
		sprite.transform.position += movement;
	}
	/// <summary>
	/// OnCollisionEnter is called when this collider/rigidbody has begun
	/// touching another rigidbody/collider.
	/// </summary>
	/// <param name="other">The Collision data associated with this collision.</param>
	void OnCollisionEnter(Collision other)
	{
		// TODO: Collision detection
	}
}
