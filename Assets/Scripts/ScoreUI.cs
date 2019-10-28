using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Text gameoverText;
    int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Zombies"))
        {
            Debug.Log("reaching");
            gameoverText.text = "" + score;
        }
    }
}
