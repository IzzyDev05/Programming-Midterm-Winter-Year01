using UnityEngine;

public class CarTest : MonoBehaviour
{
    private Car myCar1 = new Car(); // This uses the default constructor
    private Car myCar2 = new Car("Jeremy"); // This uses the constructor with only 1 variable
    private Car myCar3 = new Car("Jonathan", "Pink", 8000f); // This uses the 3rd constructor which had 3 parameters

    [SerializeField] private Car myCar4; // This is only visible because of the [System.Serializable] attribute


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            myCar1.PrintCarDetails();
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            myCar2.PrintCarDetails();
        }
        if (Input.GetKeyDown(KeyCode.E)) {
            myCar3.PrintCarDetails();
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            myCar4.PrintCarDetails();
        }
    }
}