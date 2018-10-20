using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    
	[SerializeField] private int hp;
	[SerializeField] private float movementSpeed;
	[SerializeField] private float jumpForce;

    [SerializeField] private float attackDamage;
    [SerializeField] private float attackSpeed;

	public void TakeDamage()
	{
       
	}

	public void OnHit()
	{
		TakeDamage();
	}

    public void jump(Rigidbody2D body){
        body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
	}

    public void moveHorizontal(Rigidbody2D body, float direction) {
        body.velocity = new Vector2 (direction * movementSpeed, body.velocity.y);

    }


}
