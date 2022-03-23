using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public float speed;

    public Text currentTimeText;
    public Text currentTimeMenuText;
    public Text currentTimeYouWinMenuText;

    public Text bricksDestroyedText;
    public Text bricksDestroyedMenuText;
    public Text bricksDestroyedYouWinMenuText;

    public GameObject youWinScreen;

    float currentTime = 0;
    float currentMenuTime = 0;
    float currentYouWinMenuTime = 0;

    Rigidbody2D rb;

    int bricksCount = 0;
    int bricksDestroyed = 0;

    int bricksMenuCount = 0;
    int bricksDestroyedMenu = 0;

    int bricksYouWinMenuCount = 0;
    int bricksDestroyedYouWinMenu = 0;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start(){
        Invoke(nameof(BallRandomStart), 1f);
    }

    private void BallRandomStart(){
        
        Vector2 force = Vector2.zero;
        force.x = UnityEngine.Random.Range(-0.5f, 0.5f);
        force.y = -1f;

        rb.AddForce(force.normalized * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        
        if (collision.gameObject.tag == "Brick"){
            
            bricksCount++;
            bricksMenuCount++;
            bricksYouWinMenuCount++;


            BricksDestroyedCounter();
            BricksDestroyedMenuCounter();
            BricksDestroyedYouWinMenuCounter();

            Destroy(collision.gameObject);
        }
    }

    private void FixedUpdate(){

        StopWatch();
    }

    void StopWatch(){
        
        // this is for the gameplay timer and bricks counter

        if (bricksCount != 27){
            currentTime = currentTime + Time.deltaTime;
        }

        else if(bricksCount == 27){
            youWinScreen.SetActive(true);
            Destroy(gameObject);
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();

        // this is for the GameOver timer and bricks counter

        if (bricksMenuCount != 27){
            currentMenuTime = currentMenuTime + Time.deltaTime;
        }

        else if (bricksMenuCount == 27){
            youWinScreen.SetActive(true);
            Destroy(gameObject);
        }

        TimeSpan timeMenu = TimeSpan.FromSeconds(currentMenuTime);
        currentTimeMenuText.text = timeMenu.Minutes.ToString() + ":" + timeMenu.Seconds.ToString();

        // this is for the YouWin timer and bricks counter

        if (bricksYouWinMenuCount != 27)
        {
            currentYouWinMenuTime = currentYouWinMenuTime + Time.deltaTime;
        }

        else if (bricksYouWinMenuCount == 27)
        {
            youWinScreen.SetActive(true);
            Destroy(gameObject);
        }

        TimeSpan timeYouWinMenu = TimeSpan.FromSeconds(currentYouWinMenuTime);
        currentTimeYouWinMenuText.text = timeYouWinMenu.Minutes.ToString() + ":" + timeYouWinMenu.Seconds.ToString();
    }

    void BricksDestroyedCounter(){

        bricksDestroyed++;
        bricksDestroyedText.text = bricksDestroyed.ToString() + "/27";
    }

    void BricksDestroyedMenuCounter(){

        bricksDestroyedMenu++;
        bricksDestroyedMenuText.text = bricksDestroyedMenu.ToString() + "/27";
    }

    void BricksDestroyedYouWinMenuCounter(){

        bricksDestroyedYouWinMenu++;
        bricksDestroyedYouWinMenuText.text = bricksDestroyedYouWinMenu.ToString() + "/27";
    }
}
