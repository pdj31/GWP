using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public static int score = 0;

    public static Text ScoreText;


    // public static int score = 0;
    // public Text scoreText;
   // public static int score = 0;

    //public static Text ScoreText;
    public static bool flag = false;

    // private void Start() {
    //     ScoreText.text = "";
    // }

    // private void Update() {
    //     ScoreText.text = " " + score;
    // }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "A1"){
            flag = true;
            if(flag && score < 1){
                score+=1;
                // ScoreText.text = score.ToString();

            }
            flag = false;
            Debug.Log("Score is " + score);
            // gameObject.SetActive(false);   
        }
        if(other.gameObject.name == "A2"){
            flag = true;
            if(flag && score < 2){
                score+=1;
                // ScoreText.text = score.ToString();

            }
            flag = false;
            Debug.Log("Score is " + score);
            // gameObject.SetActive(false);   
        }
        if(other.gameObject.name == "A3"){
            flag = true;
            if(flag && score < 3){
                score+=1;
                // ScoreText.text = score.ToString();

            }
            flag = false;
            Debug.Log("Score is " + score);
            // gameObject.SetActive(false);   
        }
        if(other.gameObject.name == "A4"){
            flag = true;
            if(flag && score < 4){
                score+=1;
                // ScoreText.text = score.ToString();

            }
            flag = false;
            Debug.Log("Score is " + score);
            // gameObject.SetActive(false);
            
        }        
    }
}    
