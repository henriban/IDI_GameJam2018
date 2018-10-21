using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaeBlade : MonoBehaviour, Costume_Interface {

	private int damage = 100;
	private string name = "baeblade";
	private float attackWidth = 0.2f;
	private float attackForce = 30f;
	private float attackTime = 1f;
	private float currentTime = 1;

	public int getDamage() {
		return damage;
	}

	public string getName() {
		return name;
	}

	public void onSpecial(Player p) {
		if(currentTime == attackTime) {
			Rigidbody2D r2d = p.GetComponent<Rigidbody2D>();
			r2d.sharedMaterial = (PhysicsMaterial2D)(Resources.Load("BouncingBae"));
			p.GetComponent<Rigidbody2D>().AddForce(new Vector2(attackForce * p.getDirection(), 10f), ForceMode2D.Impulse);
			currentTime = attackTime;
			IEnumerator test = youSpinMeRightRoundBBY(p);
			StartCoroutine(test);
		}
	}

	public IEnumerator youSpinMeRightRoundBBY(Player p) {
		while(currentTime > 0) {
			p.attack(attackWidth);
			currentTime -= Time.deltaTime;
			yield return new WaitForSeconds(0);
		}
		currentTime = attackTime;
		p.GetComponent<Rigidbody2D>().sharedMaterial = null;
	}
}
