using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCostume : MonoBehaviour {

    public SpriteRenderer spriteRenderer;

    private string skinName = "oldman_bald";
    private string folder = "BaldMan";

    public void setSkinName(string folder, string skinName){
        this.folder = folder;
        this.skinName = skinName;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        string spriteName = spriteRenderer.sprite.name;
        string spriteAction = spriteName.Split("_"[0])[2];

        Sprite[] subSprites = Resources.LoadAll<Sprite>("Sprites/" + folder + "/" + skinName + "_" + spriteAction);

        Sprite newSprite = null;
        foreach (Sprite sprite in subSprites) {
            if (sprite.name[sprite.name.Length - 1] == spriteName[spriteName.Length - 1]) {
                newSprite = sprite;
            }
        }
        if (newSprite) {
            spriteRenderer.sprite = newSprite;
        } else if (subSprites.Length != 0) {
            spriteRenderer.sprite = subSprites[0];    
        }

        if (Input.GetKeyDown(KeyCode.P)) {
            print("Sprites/" + folder + "/" + skinName + "_" + spriteAction);
        }
	}
}
