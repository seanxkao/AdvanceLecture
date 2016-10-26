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
            Vector3 offset = transform.position - collision.gameObject.transform.position;
            int numPotion = potionP.Length;
            int idx = Random.Range (0, numPotion);
            GameObject potion = (GameObject)Instantiate(potionP[idx]);
            potion.transform.position = transform.position + offset;
            GetComponent<MeshRenderer>().material.color = Color.black;
            isUsed = true;
        }
    }
}
