using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaeBlade : MonoBehaviour, Costume_Interface {

	private int damage = 100;
	private string name = "Baeblade";
	private float force = 30;
	private float attackWidth = 0.5f;
	private float time = 1f;
	private float timer = 1f;

	public int getDamage() {
		return damage;
	}

	public string getName() {
		return name;
	}

	public void onSpecial(Player p) {
		if(timer == time) {
			Rigidbody2D r2d = p.GetComponent<Rigidbody2D>();
			r2d.sharedMaterial = (PhysicsMaterial2D) Resources.Load("BaeBlade");
			int direction = (int)p.getDirection();
			if(r2d.velocity.x > 0) {
				direction = 1;
			}
			else if(r2d.velocity.x < 0) {
				direction = -1;
			}
			r2d.AddForce(new Vector2(direction * force, 10), ForceMode2D.Impulse);
			StartCoroutine(youSpinMeRightRounBBY(p));
		}
	}

	private IEnumerator youSpinMeRightRounBBY(Player p) {

		while(timer > 0) {
			p.attack(attackWidth);
			timer -= Time.deltaTime;
			yield return new WaitForSeconds(0);
		}

		timer = time;
		p.GetComponent<Rigidbody2D>().sharedMaterial = null;
	}

}
