using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	    AssetBundle.LoadFromFile("Assets/_Scenes");
	}

    public void StartGame()
    {
        SceneManager.LoadScene("NeilTysonFight");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
