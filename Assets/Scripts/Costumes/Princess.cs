using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Princess : MonoBehaviour, Costume_Interface {

    private bool isFrog = false;

    public int getDamage()
    {
        return 0;
    }

    public string getName()
    {
        return "princess";
    }

    public void onSpecial(Player p)
    {
        p.costumeTransform("Princess", "princess_frog");
        //BoxCollider2D bc2d = p.GetComponent < BoxCollider2D >();
        //SpriteRenderer spriteRenderer = p.GetComponent<SpriteRenderer>();
        //bc2d.size = new Vector2(0.3f, 0.25f);
        //print(bc2d.size);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
