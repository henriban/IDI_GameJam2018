using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCostume : MonoBehaviour {

    public string skinName;
    public string folder;
    public SpriteRenderer renderer;

    public void setSkinName(string folder, string skinName){
        this.folder = folder;
        this.skinName = skinName;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        Sprite[] subSprites = Resources.LoadAll<Sprite>("Sprites/" + folder + "/" + skinName);

        string spriteName = renderer.sprite.name;
        
        Sprite newSprite = null;
        foreach (Sprite sprite in subSprites) {
            if (sprite.name[sprite.name.Length - 1] == spriteName[spriteName.Length - 1]) {
                newSprite = sprite;
            }
        }
        if (newSprite) {
            renderer.sprite = newSprite;
        }
	}
}
