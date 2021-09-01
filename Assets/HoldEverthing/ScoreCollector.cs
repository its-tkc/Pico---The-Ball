using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCollector : MonoBehaviour
{
    [SerializeField] GameObject newHighScore;
    [SerializeField] Text score1, score2, score3, highscore1, highscore2, highscore3;
    private int initialScore, initialHighScore;

    public static int finalScore, score;
    public static int finalHighScore, highScore;


    //----------------------------------------------------------------
    void Start()
    {
       
        finalScore = 0;
        initialScore = 0;
        initialHighScore = PlayerPrefs.GetInt("finalhighscore",0); 

        score1.text = "Score: " + initialScore.ToString();
        score2.text = "Score: " + initialScore.ToString();
        score3.text = "Score: " + initialScore.ToString();

        highscore1.text = "HighScore: " + initialHighScore.ToString();
        highscore2.text = "HighScore: " + initialHighScore.ToString();
        highscore3.text = "HighScore: " + initialHighScore.ToString();

        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "Level1")
        {
            Debug.Log("Welcome to The Level1");
        }


    }

    //----------------------------------------------------------------
    void Update()
    {
        finalScore = score;
        

        score1.text = "Score: " + finalScore.ToString();
        score2.text = "Score: " + finalScore.ToString();
        score3.text = "Score: " + finalScore.ToString();

        

        if(finalScore > PlayerPrefs.GetInt("finalhighscore", 0))
        {
            PlayerPrefs.SetInt("finalhighscore", finalScore);

            highscore1.text = "HighScore: " + PlayerPrefs.GetInt("finalhighscore", 0).ToString();
            highscore2.text = "HighScore: " + PlayerPrefs.GetInt("finalhighscore", 0).ToString();
            highscore3.text = "HighScore: " + PlayerPrefs.GetInt("finalhighscore", 0).ToString();

            if (!newHighScore.activeInHierarchy)
            {
                newHighScore.SetActive(true);
            }
        }

    }

    //----------------------------------------------------------------

    public void ResetScore()
    {
       
        score = 0;
        
    }


    private void OnEnable()
    {
        score = 0;
        
    }

   
}
