using UnityEngine;
using System.Collections;

public class Potion : MonoBehaviour {

    protected Color color;

    protected virtual void Start() {
    }

    public virtual void drink(Player player) {
        Debug.Log ("drink!");
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Player player = collider.gameObject.GetComponent<Player>();
            player.GetComponent<MeshRenderer>().material.color = color;
            GetComponent<MeshRenderer> ().enabled = false;
            transform.parent = player.transform;
            player.setPotionOnHand (this);
        }
    }
}
