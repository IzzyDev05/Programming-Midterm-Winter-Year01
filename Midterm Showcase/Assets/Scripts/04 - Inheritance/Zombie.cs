/*
This child class inherits both properties and methods of Enemy, as well as having it's own property (attackDamage) and functions (Update and Attack).
base basically means the exact same code as what is present in the original method in the parent script.
*/

using UnityEngine;

public class Zombie : Enemy
{
    [SerializeField] private float attackDamage = 10f;

    public override void TakeDamage(float damageAmount) {
        base.TakeDamage(damageAmount);
        Debug.Log("Zombie took " + damageAmount + " damage");
    }

    protected override void Die() {
        base.Die();
        Debug.Log("Zombie died");
    }
    
    private void Update() {
        print("The zombie is moving towards the player!");

        if (Input.GetKeyDown(KeyCode.Q)) Attack();
        if (Input.GetKeyDown(KeyCode.W)) TakeDamage(25f);
    }

    public void Attack() {
        Debug.Log("Zombie attacked for " + attackDamage + " damage");
    }
}