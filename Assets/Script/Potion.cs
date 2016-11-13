using UnityEngine;
using System.Collections;

public class Potion : MonoBehaviour {

    protected Color color;
    protected virtual void Start() {
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Player player = collider.gameObject.GetComponent<Player>();
            player.GetComponent<MeshRenderer>().material.color = color;
            Destroy(gameObject);
        }
    }
}
