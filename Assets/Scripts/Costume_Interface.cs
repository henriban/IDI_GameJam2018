using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Costume_Interface {
	
    void onSpecial(Player p);

	void onEquip(Player p);

	int getDamage();

}
