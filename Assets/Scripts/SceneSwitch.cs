using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public void LoadGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
    }
}
