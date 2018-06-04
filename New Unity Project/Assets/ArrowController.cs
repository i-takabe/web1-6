using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

    GameObject player;

	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -0.1f, 0);
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 arrowCollision = transform.position;
        Vector2 playerCollision = this.player.transform.position;
        Vector2 dir = arrowCollision - playerCollision;

        float d = dir.magnitude;
        float arrowCollisonSize = 0.5f;
        float playerCollisonSize = 1.0f;

        if(d < arrowCollisonSize + playerCollisonSize)
        {

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            Destroy(gameObject);
        }
    }
}
