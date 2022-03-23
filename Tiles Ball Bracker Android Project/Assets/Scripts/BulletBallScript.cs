using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBallScript : MonoBehaviour
{
    public float bulletForce;

    Rigidbody2D rb;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start(){
        rb.AddForce(Vector2.up * bulletForce);
    }
}
