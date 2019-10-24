using UnityEngine;

public class Target_Damage : MonoBehaviour
{
    public float health = 50f;

    public void takeDamage(float amt)
    {
        health -= amt;

        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
