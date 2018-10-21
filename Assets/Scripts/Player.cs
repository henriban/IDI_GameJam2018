using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

    [SerializeField] private LayerMask groundMask;
    [SerializeField] private LayerMask enemyMask;


    public static Player player;

    private Rigidbody2D rb2d;
    private BoxCollider2D bc2d;
    private SpriteRenderer spriteRenderer;

	private List<Hat_Interface> hats;
	private List<Costume_Interface> costumes;

	private int activeHat;
    private int activeCostume;

    private Collider2D firstOverlappingGroundCollider;

    private float faceDirection = 1.0f;
    private bool doubleJump = false;
    private bool canDoubleJump = false;
    private int numberOfJumps;

    // Use this for initialization
    void Start () {
		if(player == null) {
			player = this;
			DontDestroyOnLoad(this);
		}
		else {
			Destroy(this);
		}

        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
		hats = new List<Hat_Interface>();
		costumes = new List<Costume_Interface>();
        costumes.Add(new FighterCostume());
        activeHat = 0;
        activeCostume = 0;
        numberOfJumps = 0;
        
	}

	private void Update() {

		//Hats
		if(Input.GetKeyDown(KeyCode.Q)) {

			hats[activeHat].unequip();

			if(activeHat < hats.Count - 1) {
				activeHat++;
			}
			else {
				activeHat = 0;
			}

			hats[activeHat].onEquip();
		}

		//Costumes
		if(Input.GetKeyDown(KeyCode.E)) {
			if(activeCostume < costumes.Count - 1) {
				activeHat++;
			}
			else {
				activeHat = 0;
			}
			setAttackDamage(costumes[activeCostume].getDamage());
		}

		if(Input.GetKeyDown(KeyCode.Space)) {
			costumes[activeCostume].onSpecial(this);
		}

        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            faceDirection = Input.GetAxisRaw("Horizontal");
        }
	}

	// Update is called once per frame
	void FixedUpdate () {

        //Inputs
        if (Input.GetAxis("Horizontal") != 0 && canMoveHorizontaly(Input.GetAxis("Horizontal")))
        {
            base.moveHorizontal(rb2d, Input.GetAxis("Horizontal"));
        }

        if (Input.GetAxisRaw("Vertical") > 0.0f && canJump())
        {
            canDoubleJump = false;
            base.jump(rb2d);
            numberOfJumps += 1;
        }

        if (Input.GetAxisRaw("Vertical") == 0.0f)
        {
            canDoubleJump = true;
        }

    }

    private bool canJump()
    {
        if (doubleJump && numberOfJumps <= 1 && canDoubleJump)
        {
            return true;
        }

        // Check if the point underneath the player is ground
        Vector2 position = rb2d.transform.position;
        Vector2 pointToCheck = new Vector2(position.x, position.y - spriteRenderer.bounds.extents.y);
        //Vector2 pointToCheck = new Vector2(position.x, position.y - bc2d.size.y / 2f - 0.1f);
        firstOverlappingGroundCollider = Physics2D.OverlapCircle(pointToCheck, 0.1f, groundMask);

        //print(getCostumeString());
        bool toJump = firstOverlappingGroundCollider != null;
        if (toJump){
           numberOfJumps = 0;
        }
            
        return toJump;
    }

    public void attack(float attackWidth)
    {
        
        float pointXToCheck = rb2d.transform.position.x + (faceDirection * (spriteRenderer.bounds.extents.x + (attackWidth/2)));
        float pointYToCheck = rb2d.transform.position.y + 0.1f;
        Vector2 pointToCheck = new Vector2(pointXToCheck, pointYToCheck);

        Vector2 attackSize = new Vector2(attackWidth, spriteRenderer.bounds.size.y);

        Collider2D[] firstEnemyCollider = Physics2D.OverlapBoxAll(pointToCheck, attackSize, 0.0f, enemyMask);
        foreach (Collider2D collider in firstEnemyCollider){
            collider.GetComponent<Character>().takeDamage(getAttackDamage(), faceDirection);
        }

    }

    private bool canMoveHorizontaly(float direction)
    {
        if (direction > 0) {
            direction = 1;
        } else {
            direction = -1;
        }
        // Check if the given point next to the player is ground
        Vector2 position = rb2d.transform.position;
        Vector2 pointToCheck = new Vector2(position.x + spriteRenderer.bounds.extents.x * direction, position.y);
        //firstOverlappingGroundCollider = Physics2D.OverlapCircle(pointToCheck, 0.1f, groundMask);
        firstOverlappingGroundCollider = Physics2D.OverlapBox(pointToCheck, new Vector2(0.1f, spriteRenderer.bounds.extents.y * 2.0f - 0.1f), 0f, groundMask);

        bool toMove = firstOverlappingGroundCollider == null;
        return toMove;
    }
  
    public float getDirection()
    {
        return faceDirection;
     }
    private string getCostumeString() {
        string costume = costumes[activeCostume].getName();
        string hat = hats[activeHat].getName();
        return costume + hat;
    }

    public void setDoubleJump(bool active)
    {
        doubleJump = active;
    }
}
