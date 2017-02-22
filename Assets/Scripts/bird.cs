using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
    public float upForce = 200f;
    private bool isDead = false;
    private Rigidbody2D rigid;
    private Animator anim;

	// Use this for initialization
	void Start () {
        this.anim = this.GetComponent<Animator>();
        this.rigid = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rigid.velocity = Vector2.zero;
                rigid.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rigid.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        gameControl.instance.BirdDied();
    }
}
