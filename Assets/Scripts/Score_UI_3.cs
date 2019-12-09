using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_UI_3 : MonoBehaviour
{
    [SerializeField] Text gameoverText;

    public int score = 0;

    public void increaseScore()
    {
        score++;
        gameoverText.text = "" + score;
    }
}
