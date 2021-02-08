using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded=false;
    public Text gameend;
    public GameObject endOfLevelUI;
    public float delay = 2f;

    public void WinLevel()
    {
        endOfLevelUI.SetActive(true);
    }
public void GameOver()
    {
        if (gameHasEnded==false)
        {
            gameHasEnded = true;
            gameend.text = "Game Over !";
            Invoke("Reset", delay);
        }
    }
    private void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
