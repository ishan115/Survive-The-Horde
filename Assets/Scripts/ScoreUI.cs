using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Text gameoverText;

    public int score = 0;
    //private void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.CompareTag("Zombies"))
    //    {
    //        GameObject bullet = GameObject.FindGameObjectWithTag("Bullet");
    //        Collision_Detection cd = bullet.GetComponent<Collision_Detection>();

    //        score = cd.scoreNumberUI;
    //        gameoverText.text = "" + score;
    //    }
    //}

    public void increaseScore()
    {
        score++;
        gameoverText.text = "" + score;
    }
}
