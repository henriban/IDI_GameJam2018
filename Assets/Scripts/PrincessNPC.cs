using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessNPC : Character {

    public GameObject dress;

    void OnDestroy() {
        Instantiate(dress, transform.position, transform.rotation);
    }
}
