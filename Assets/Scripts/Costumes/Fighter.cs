using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour, Costume_Interface {

    private int damage = 50;

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
        p.attack(3.0f);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
