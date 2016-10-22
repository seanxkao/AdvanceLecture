using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    protected float speed;
    protected int score;
    protected int vx;
    protected int vy;

    void Start() {
        speed = 5f;
    }

	void Update () {
        vx = 0;
        vy = 0;
        if (Input.GetKey(KeyCode.LeftArrow)) {
            vx--;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vx++;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vy++;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vy--;
        }
	}

    public void FixedUpdate(){
        GetComponent<Rigidbody>().velocity = new Vector3(vx, 0, vy) * speed;
    }

    public void addScore() {
        score++;
        if (score == 10) {
            Debug.Log("You win!");
        }
    }


}
