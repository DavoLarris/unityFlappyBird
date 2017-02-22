using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<bird>() != null)
        {
            gameControl.instance.BirdScore();
        }
    }
}
