using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelHat : MonoBehaviour, Hat_Interface {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public string getName()
    {
        return "Catears";
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
