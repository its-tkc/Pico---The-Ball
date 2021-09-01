using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void LoadmainMenu()
    {
        SceneManager.LoadScene(1);

    }


    public void LoadLvL1()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit was Pressed");
    }

    public void ResetStates()
    {
        PlayerPrefs.DeleteAll();
    }

    public void LoadInventory()
    {
        SceneManager.LoadScene(3);
    }
}
