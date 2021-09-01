using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<Text> texti;
    public static int coin, gem, coinContainer, gemContainer;


    private void OnEnable()
    {
        coin = PlayerPrefs.GetInt("coin");
        gem = PlayerPrefs.GetInt("gem");
       
    }

    void Start()
    {

        
    }

    
    void Update()
    {
       
       
        texti[0].text = "coins:" + (coin + coinContainer).ToString();
        texti[1].text = "gems:" + (gem + gemContainer).ToString();

    }

    private void OnDisable()
    {
        coin += coinContainer;
        gem += gemContainer;

        PlayerPrefs.SetInt("coin", coin);
        PlayerPrefs.SetInt("gem", gem);

        coinContainer = 0;
        gemContainer = 0;
    }


}
