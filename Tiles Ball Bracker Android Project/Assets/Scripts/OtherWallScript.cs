using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherWallScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "Ball"){

            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}
