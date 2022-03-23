using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PaddelScript : MonoBehaviour
{
    public float speed;

    private void Update(){
        float movement = CrossPlatformInputManager.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.88f, 8.88f),transform.position.y,transform.position.z);
    }
}
