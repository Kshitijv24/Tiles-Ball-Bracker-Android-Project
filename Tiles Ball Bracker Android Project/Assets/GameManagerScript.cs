using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit(){

        Application.Quit();
    }
}
