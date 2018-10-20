using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	[SerializeField] private int hp;
	[SerializeField] private float movementSpeed;
	[SerializeField] private float jumpForce;

	public void TakeDamage()
	{

	}

	public void OnHit()
	{
		TakeDamage();
	}

	public void moveRight()
	{

	}

	public void moveLeft()
	{

	}

	public void jump()
	{

	}
}
