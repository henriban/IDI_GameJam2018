using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMan : MonoBehaviour, Costume_Interface {

    public int getDamage()
    {
        return 1;
    }

    public string getName()
    {
        return "oldman";
    }

    public void onSpecial(Player p)
    {
        throw new System.NotImplementedException();
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
