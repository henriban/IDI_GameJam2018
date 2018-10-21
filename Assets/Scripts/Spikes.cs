using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : Character {

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Player") {
            collision.gameObject.GetComponent<Player>().takeDamage(getAttackDamage(), 1, 30f, 1);
        }
    }
}