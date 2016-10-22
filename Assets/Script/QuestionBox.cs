using UnityEngine;
using System.Collections;

public class QuestionBox : MonoBehaviour {
    bool isUsed;
    public GameObject posionP;

    void Start() {
        isUsed = false;
    }

    void OnCollisionEnter(Collision collision) {
        if(!isUsed && collision.gameObject.name == "Player"){
            Vector3 offset = transform.position - collision.gameObject.transform.position;
            GameObject posion = (GameObject)Instantiate(posionP);
            posion.transform.position = transform.position + offset;
            GetComponent<MeshRenderer>().material.color = Color.black;
            isUsed = true;
        }
    }
}
