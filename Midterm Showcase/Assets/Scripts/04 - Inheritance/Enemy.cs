/*
The parent class has 2 properties, health and moveSpeed. These are public so they can be used in all inherited classes.
You could also make this internal instead of public. Internal is like private, except private is current script only and internal is current and child scripts
*/

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    public float moveSpeed = 5f;

    // Adding virtual makes it so that children classes can modify this method.
    public virtual void TakeDamage(float damageAmount) {
        health -= damageAmount;

        if (health <= 0f) {
            Die();
        }
    }

    // protected means that this method is only accessible in this class and any classes derived from it (So if a script derives from MonoBehaviour and not Enemy, you can't call die)
    protected virtual void Die() {
        Destroy(gameObject);
    }
}