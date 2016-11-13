using UnityEngine;
using System.Collections;

public class MagicPotion : Potion {

	// Use this for initialization
    protected override void Start () {
        color = Color.green;
	}
    public override void drink (Player player)
    {
        base.drink (player);
        player.GetComponent<SphereCollider> ().isTrigger = true;
    }
}
