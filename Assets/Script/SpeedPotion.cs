using UnityEngine;
using System.Collections;

public class SpeedPotion : Potion {

	// Use this for initialization
    protected override void Start () {
        color = Color.blue;
	}

    public override void drink (Player player)
    {
        base.drink (player);
        player.setSpeed (10.0f);
    }
}
