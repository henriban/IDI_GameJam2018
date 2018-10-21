using UnityEngine;
using System.Collections;

public class Bald : MonoBehaviour, Hat_Interface
{
    public string getName()
    {
        return "bald";
    }

    public void onEquip()
    {
        // TODO: reset player to default
    }

    public void unequip()
    {
        return;
    }

    // Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
			
	}
}
