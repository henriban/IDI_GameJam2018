using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterCostume : MonoBehaviour, Costume_Interface {

    private int damage = 20;

    public int getDamage()
    {
        return damage;
    }

    public string getName()
    {
        return "fighter";
    }

    public void onSpecial(Player p)
    {
        p.attack(10.0f);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
