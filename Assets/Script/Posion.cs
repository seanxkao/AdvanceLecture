using UnityEngine;
using System.Collections;

public class Posion : MonoBehaviour {
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Player player = collider.gameObject.GetComponent<Player>();
            player.GetComponent<MeshRenderer>().material.color = Color.red;
            Destroy(gameObject);
        }
    }
}
