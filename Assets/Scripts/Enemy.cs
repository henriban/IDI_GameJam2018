using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character {

	[SerializeField] private float attackDamage;
	[SerializeField] private float attackSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
		

	}
}
