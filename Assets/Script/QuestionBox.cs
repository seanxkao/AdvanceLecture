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
            Vector3 offset = transform.position - collision.gameObject.transform.position;
            Vector3 pos = Vector3.zero;
            if (Mathf.Abs(offset.x) > Mathf.Abs(offset.z))
            {
                if (offset.x > 0)
                {
                    pos.x = 1;
                }
                else
                {
                    pos.x = -1;
                }
            }
            else
            {
                if (offset.z > 0)
                {
                    pos.z = 1;
                }
                else
                {
                    pos.z = -1;
                }
            }
            GameObject Potion = (GameObject)Instantiate(PotionP);
            Potion.transform.position = transform.position + pos;
            GetComponent<MeshRenderer>().material.color = Color.black;
            isUsed = true;
        }
    }
}
