using UnityEngine;
using System.Collections;

public class QuestionBox : MonoBehaviour {
    protected bool isUsed;
    public GameObject[] potionP;

    void Start() {
        isUsed = false;
    }

    void OnCollisionEnter(Collision collision) {
        if(!isUsed && collision.gameObject.name == "Player"){
            Vector3 dist = collision.gameObject.transform.position - transform.position;
            Vector3 offset = Vector3.zero;
            if (Mathf.Abs(dist.x) > Mathf.Abs(dist.z))
            {
                if (dist.x > 0)
                {
                    offset.x = -1;
                }
                else
                {
                    offset.x = 1;
                }
            }
            else
            {
                if (dist.z > 0)
                {
                    offset.z = -1;
                }
                else
                {
                    offset.z = 1;
                }
            }
                
            int numPotion = potionP.Length;
            int idx = Random.Range (0, numPotion);
            GameObject potion = (GameObject)Instantiate(potionP[idx]);
            potion.transform.position = transform.position + offset;
            GetComponent<MeshRenderer>().material.color = Color.black;
            isUsed = true;
        }
    }
}
