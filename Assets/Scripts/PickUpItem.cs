﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Item")) {
            if (collision.GetComponent<Costume_Interface>() != null) {
				if(this.GetComponent<Costume_Interface>().GetType() == collision.GetComponent<Costume_Interface>().GetType()) {
					Player.player.addCostume(this.GetComponent<Costume_Interface>());
				}
				else {
					Player.player.addCostume(collision.GetComponent<Costume_Interface>());
				}
                
            }else if(collision.GetComponent <Hat_Interface>() != null) {
                Player.player.addHat(collision.GetComponent<Hat_Interface>());
            }

            Destroy(collision.gameObject);
        }
    }
}
