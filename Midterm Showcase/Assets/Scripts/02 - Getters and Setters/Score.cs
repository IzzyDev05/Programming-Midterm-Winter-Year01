/*
We use a get-set function to give us access to the value of a private variable in different scripts without making the variable public.
We also use a get-set function if we want to set a restriction on the value.
(Also called properties)
*/

using UnityEngine;

public class Score
{
    private int point;
    private int restrictedPoint;

    private int lives;

    // Common practice is to make a get-set function with the same name as the variable, just capitalized
    public int Point {
        get {
            return point;
        }
        set {
            point = value;
        }
    }

    public int RestrictedPoint {
        get {
            return restrictedPoint;
        }
        set {
            if (value > 5 && value < 10) {
                restrictedPoint = value;
                SayHi(); // You can call other functions from directly inside a get-set function
            }
            else {
                // 0 is the default value, so you don't need this else statement. This is just to show that you can change the value based on the input.
                restrictedPoint = 999;
                SayBye();
            }
        }
    }

    private void SayHi() {
        Debug.Log("Hello!");
    }

    private void SayBye() {
        Debug.Log("Farewell!");
    }

    // This is an auto property. This is the same thing as the Point get-set, just written in a short manner.
    public int Lives { get; set; }
}