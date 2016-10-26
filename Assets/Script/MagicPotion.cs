using UnityEngine;
using System.Collections;

public class MagicPotion : Potion {

	// Use this for initialization
	override protected void Start () {
        color = Color.green;
	}
    public override void drink (Player player)
    {
        base.drink (player);
        player.GetComponent<BoxCollider> ().isTrigger = true;
    }
}
