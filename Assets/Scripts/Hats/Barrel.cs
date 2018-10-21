using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, Hat_Interface {

    float movementDebuff = 0.5f;

    public string getName() {
        return "big";
    }

    public void onEquip() {
        Player.player.setNoJump(true);
        Player.player.setMovementSpeed(Player.player.getMovementSpeed() * movementDebuff);
    }

    public void unequip() {
        Player.player.setNoJump(false);
        Player.player.setMovementSpeed(Player.player.getMovementSpeed() / movementDebuff);
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}

