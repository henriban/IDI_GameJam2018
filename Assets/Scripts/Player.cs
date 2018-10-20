using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public static Player player;

	private List<Hat_Interface> hats;
	private List<Costume_Interface> costumes;

	private int activeHat;
	private int activeCostume;

	// Use this for initialization
	void Start () {
		if(player == null) {
			player = this;
			DontDestroyOnLoad(this);
		}
		else {
			Destroy(this);
		}
		hats = new List<Hat_Interface>();
		costumes = new List<Costume_Interface>();
	}
	
	// Update is called once per frame
	void Update () {
		//Inputs
	}
}
