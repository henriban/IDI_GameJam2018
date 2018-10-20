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

    public void OnFire()
    {
        throw new NotImplementedException();
    }

    public void OnSpecial()
    {
        throw new NotImplementedException();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
