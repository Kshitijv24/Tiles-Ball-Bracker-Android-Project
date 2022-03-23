using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Ball"){

            GetComponent<Renderer>().material.color = Color.red;
            Destroy(collision.gameObject);

            gameOverScreen.SetActive(true);
        }
    }
}
