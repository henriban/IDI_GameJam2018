using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    
	[SerializeField] private int hp;
	[SerializeField] private float movementSpeed;
	[SerializeField] private float jumpForce;

  [SerializeField] private int attackDamage;
  [SerializeField] private float attackSpeed;
  [SerializeField] private bool canMove = true;

	public void takeDamage(int damageDone, float direction, float force = 4.0f, float verticalDirection = 0)
	{
        Debug.Log("Getting hurt");


        setCanMove(false);
        StartCoroutine("damagePush");

        Rigidbody2D charRb2d = gameObject.GetComponent<Rigidbody2D>();
        charRb2d.AddForce(new Vector2(force * direction, force * verticalDirection), ForceMode2D.Impulse);

        setHitPoints(getHitPoints() - damageDone);
        if(getHitPoints() <= 0)
        {
            if (gameObject.tag == "Player")
            {
                gameObject.GetComponent<Player>().deathReset();
            } else {
                Destroy(gameObject);
            }
        }
	}

    IEnumerator damagePush()
    {
        yield return new WaitForSeconds(0.5f);
        setCanMove(true);

    }

    public void jump(Rigidbody2D body){
        body.velocity = new Vector2(body.velocity.x, 0.0f);
        body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
	}

    public void moveHorizontal(Rigidbody2D body, float direction) {
        if (canMove) {
            body.velocity = new Vector2(direction * movementSpeed, body.velocity.y);
            GetComponent<SpriteRenderer>().flipX = direction < 0;
        } 
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

    public void setCanMove(bool canMove)
    {
        this.canMove = canMove;
    }
}
