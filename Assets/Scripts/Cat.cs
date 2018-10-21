using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Character {

    public GameObject kittyEars;

    void OnDestroy() {
        Instantiate(kittyEars, transform.position, transform.rotation);
    }
}
