using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slimon : Character {


    private Rigidbody2D rb2d;
    private CircleCollider2D cc2d;
    private SpriteRenderer sprite;
    [SerializeField] private LayerMask groundMask;
    private float moveDirection;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        moveDirection = 1.0f;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        float pointXToCheck = rb2d.transform.position.x + (moveDirection * (GetComponent<CircleCollider2D>().radius));
        float pointYToCheck = rb2d.transform.position.y - GetComponent<CircleCollider2D>().bounds.extents.y;

        Vector2 pointToCheck = new Vector2(pointXToCheck, pointYToCheck);

        Collider2D firstOverlappingCollider = Physics2D.OverlapCircle(pointToCheck, 0.02f, groundMask);

        if (firstOverlappingCollider == null)
        {
            moveDirection = moveDirection * -1;
        }

        moveHorizontal(rb2d, moveDirection);
    }

	private void OnTriggerStay2D(Collider2D collision)
	{
  
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().takeDamage(getAttackDamage(), moveDirection);
        }
    }

    
}
