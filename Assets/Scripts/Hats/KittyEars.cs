using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittyEars : MonoBehaviour, Hat_Interface { 

    public string getName() {
        return "cat";
    }

	public void onEquip()
	{
		Player.player.setWallJump(true);
	}

	public void unequip()
	{
		Player.player.setWallJump(false);
	}
    
}
