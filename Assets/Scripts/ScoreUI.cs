using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text gameoverText;

    public int score = 0;

    public void increaseScore()
    {
        score++;
        gameoverText.text = "" + score;
    }
}
