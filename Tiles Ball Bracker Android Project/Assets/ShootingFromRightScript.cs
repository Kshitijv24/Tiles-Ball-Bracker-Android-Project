using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFromRightScript : MonoBehaviour
{
    public GameObject bullet;

    GameObject instantiatedObj;

    public void RightShoot(){

        instantiatedObj = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity);
        Destroy(instantiatedObj, 0.8f);
    }
}
