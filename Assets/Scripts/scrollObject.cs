using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollObject : MonoBehaviour {
    private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(gameControl.instance.scrollSpeed, 0);
    }
	
	// Update is called once per frame
	void Update () {
		if (gameControl.instance.gameOver)
        {
            rigid.velocity = Vector2.zero;
        }
	}
}
