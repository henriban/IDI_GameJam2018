using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    
	[SerializeField] private int hp;
	[SerializeField] private float movementSpeed;
	[SerializeField] private float jumpForce;

  [SerializeField] private int attackDamage;
  [SerializeField] private float attackSpeed;


	public void takeDamage(int damageDone)
	{
        setHitPoints(getHitPoints() - damageDone);
        Debug.Log(getHitPoints());
	}

    public void jump(Rigidbody2D body){
        body.velocity = new Vector2(body.velocity.x, 0.0f);
        body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
	}

    public void moveHorizontal(Rigidbody2D body, float direction) {
        body.velocity = new Vector2 (direction * movementSpeed, body.velocity.y);
        GetComponent<SpriteRenderer>().flipX = direction < 0;
    }

	public void setAttackDamage(int attackDamage) {
		this.attackDamage = attackDamage;
	}

    public int getAttackDamage()
    {
        return attackDamage;
    }

    public int getHitPoints()
    {
        return hp;
    }

    public void setHitPoints(int newHp)
    {
        this.hp = newHp;
    }
}
