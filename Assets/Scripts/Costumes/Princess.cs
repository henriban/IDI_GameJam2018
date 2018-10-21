using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Princess : MonoBehaviour, Costume_Interface {

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
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
