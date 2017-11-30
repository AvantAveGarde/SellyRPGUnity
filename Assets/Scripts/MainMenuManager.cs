using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

	public void StartGame(string gamelevel)
    {
        SceneManager.LoadScene(gamelevel);
    }

    public void SetActive(GameObject item)
    {
        item.SetActive(true);
    }
    
    public void SetInactive(GameObject item)
    {
        item.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
