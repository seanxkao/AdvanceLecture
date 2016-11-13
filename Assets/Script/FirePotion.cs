using UnityEngine;
using System.Collections;

public class FirePotion : Potion {

    public Material lava;

	// Use this for initialization
    protected override void Start () {
        color = Color.red;
	}
    public override void drink (Player player)
    {
        base.drink (player);
        player.GetComponent<Renderer> ().material = lava;
        player.GetComponent<ScrollingUVs_Layers> ().enabled = true;
    }
}
