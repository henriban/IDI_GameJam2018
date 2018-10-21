using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningTreeScript : Character {

    public PolygonCollider2D treeCollider;
    public GameObject firePolygon;

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Player") {
            collision.gameObject.GetComponent<Player>().takeDamage(getAttackDamage(), -1, 20f);

            extinguishBurningTree();
        }
    }

    public void extinguishBurningTree() {
        treeCollider.enabled = false;
        firePolygon.GetComponent<FireParticleEffect>().enabled = false;
    }
}
