using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseHead : MonoBehaviour, Hat_Interface {

    private float movementBoost = 20.0f;

    public string getName() {
        return "horse";
    }

    public void onEquip() {
        float newMovementSpeed = Player.player.getMovementSpeed() + movementBoost;
        Player.player.setMovementSpeed(newMovementSpeed);
    }

    public void unequip() {
        float newMovementSpeed = Player.player.getMovementSpeed() - movementBoost;
        Player.player.setMovementSpeed(newMovementSpeed);
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
