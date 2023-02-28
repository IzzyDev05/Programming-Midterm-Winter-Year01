/*
Here, we have 3 constructors. The default one, one with only one parameter and the third with 3 parameters. This can be considered overloading (?)
Without [System.Serializable], variables of type Car won't show up in the inspector.
*/

using UnityEngine;

[System.Serializable]
public class Car
{
    public string carName;
    public string carColor;
    public float carSpeed;

    public Car() {
        // Setting some default values
        carName = "Steve";
        carColor = "Burgundy";
        carSpeed = 2f;
    }

    public Car(string carName) {
        this.carName = carName;
    }

    public Car(string carName, string carColor, float carSpeed) {
        this.carName = carName;
        this.carColor = carColor;
        this.carSpeed = carSpeed;
    }

    public void PrintCarDetails() {
        Debug.Log($"The car's name is {this.carName}, the color is {this.carColor} and the speed is {this.carSpeed}.");
    }
}