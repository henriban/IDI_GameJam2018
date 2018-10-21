using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaeBlade : MonoBehaviour, Costume_Interface {

	private int damage = 100;
	private string name = "Baeblade";
	private float force = 13;
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
			r2d.AddForce(new Vector2(p.getDirection() * force, 10), ForceMode2D.Impulse);
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
	}

}
