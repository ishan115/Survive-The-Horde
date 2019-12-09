using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreUI_2 : MonoBehaviour
{
    [SerializeField] Text gameoverText;

    public int score = 0;

    public void increaseScore()
    {
        score++;
        gameoverText.text = "" + score;

        if (score == 15)
        {
            SceneManager.LoadScene("Scene_3");
        }
    }
}
