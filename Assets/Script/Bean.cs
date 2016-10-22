using UnityEngine;
using System.Collections;

public class Bean : MonoBehaviour{
    void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.name == "Player")
        {
            Player player = collider.gameObject.GetComponent<Player>();
            player.addScore();
            Destroy(gameObject);
        }
    }
}
