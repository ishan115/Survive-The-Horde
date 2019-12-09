using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public void LoadGame()
    {
        Time.timeScale = 1f;
        gameOverCanvas.SetActive(false);
        SceneManager.LoadScene("MainScene");
    }
}
