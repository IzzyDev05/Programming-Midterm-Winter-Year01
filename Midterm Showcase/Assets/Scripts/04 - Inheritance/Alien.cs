/*
Another type of enemy to show how inheritance would be used in an actual game to reduce redundancy.
Refer to the Zombie script for explanation.
*/

using UnityEngine;

public class Alien : Enemy
{
    [SerializeField] private float attackDamage = 10f;
    [SerializeField] private bool canFly = false;

    public override void TakeDamage(float damageAmount) {
        base.TakeDamage(damageAmount);
        Debug.Log("Alien took " + damageAmount + " damage");
    }

    protected override void Die() {
        base.Die();
        Debug.Log("Alien died");
    }
    
    private void Update() {
        if (canFly) print("The alien is flying towards the player!");
        else print("The alien is moving towards the player!");

        if (Input.GetKeyDown(KeyCode.Q)) Attack();
        if (Input.GetKeyDown(KeyCode.W)) TakeDamage(25f);
    }

    public void Attack() {
        Debug.Log("Alien attacked for " + attackDamage + " damage");
    }
}