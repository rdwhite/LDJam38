using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	    AssetBundle.LoadFromFile("Assets");
	}

    public void StartGame()
    {
        SceneManager.LoadScene("LVL0");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
