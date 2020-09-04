using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = "Score " + scoreValue;
        if(scoreValue > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", scoreValue);
        }
        gameObject.GetComponent<Text>().text += "\n High Score " + PlayerPrefs.GetInt("HighScore", 0);        
    }
}
