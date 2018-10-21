using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour, Hat_Interface {

    public string getName() {
        return "big";
    }

    public void onEquip() {
        // TODO: reset player to default
    }

    public void unequip() {
        return;
    }

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}

