using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] GameObject levlcomp, levlfailed;// newHighScore;

     //public Text Score;
    // public Text HighScore, newhighscore;
     //int num;
   
    void Start()
    {
        /*num = 0;
        Score.text = 0.ToString();
        HighScore.text = "HighScore:" + PlayerPrefs.GetInt("highscore", 0).ToString();*/
    }

    private void Update()
    {
        //num = CountBirds.scoreValue;
        
        if (!GameObject.FindGameObjectWithTag("Enemy") && ScoreCollector.finalScore > 200)
        {
            if (!levlcomp.activeInHierarchy)
            {
                levlcomp.SetActive(true);
            }
            
        }

        if (!GameObject.FindGameObjectWithTag("Player") && GameObject.FindGameObjectWithTag("Enemy"))
        {
            if (!levlfailed.activeInHierarchy)
            {
                levlfailed.SetActive(true);
            }

        }

        //CalculateScore();

    }

   /* void CalculateScore()
    {
        num = CountBirds.scoreValue;
        Score.text = "Score:" + num.ToString();

        if (num > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", num);
            HighScore.text = "HighScore:" + num.ToString();
            if (!newHighScore.activeInHierarchy) 
            {
                newHighScore.SetActive(true);
                newhighscore.text = "New High Score";
            }
        }
    }*/

}
