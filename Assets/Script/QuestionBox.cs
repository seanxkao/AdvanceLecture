using UnityEngine;
using System.Collections;

public class QuestionBox : MonoBehaviour {
    bool isUsed;
    public GameObject PotionP;

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
            GameObject potion = (GameObject)Instantiate(PotionP);
            potion.transform.position = transform.position + offset;
            GetComponent<MeshRenderer>().material.color = Color.black;
            isUsed = true;
        }
    }
}
