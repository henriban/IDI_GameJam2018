using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character {

	public static Player player;

    [SerializeField] private LayerMask groundMask;
    [SerializeField] private GameObject groundChecker;

    private Rigidbody2D rb2d;

	private List<Hat_Interface> hats;
	private List<Costume_Interface> costumes;

	private int activeHat;
	private int activeCostume;

    bool canJump() {
        return rb2d.velocity.y == 0;
    }

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
		hats = new List<Hat_Interface>();
		costumes = new List<Costume_Interface>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Inputs

        base.moveHorizontal(rb2d, Input.GetAxis("Horizontal"));

        if (Input.GetAxis("Vertical") > 0 && canJump())
        {
            base.jump(rb2d);
        }
	}
}
