using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour, Hat_Interface {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public string getName()
    {
        return "propeller";
    }

    public void onEquip()
    {
        Player.player.setDoubleJump(true);
    }

    public void unequip()
    {
        Player.player.setDoubleJump(false);
    }

}
