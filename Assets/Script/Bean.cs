using UnityEngine;
using System.Collections;

public class Bean : MonoBehaviour{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.addScore();
            Destroy(gameObject);
        }
    
    }
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
