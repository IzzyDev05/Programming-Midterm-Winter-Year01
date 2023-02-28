using UnityEngine;

public class Player : MonoBehaviour
{
    // Creating objects/instances of the Score class
    private Score score = new Score();
    private Score restrictedScoreReal = new Score();
    private Score restrictedScoreDefault = new Score();

    private Score lives = new Score();

    private void Start() {
        // Using the set; part of the properties
        score.Point = 5;
        restrictedScoreReal.RestrictedPoint = 8;
        restrictedScoreDefault.RestrictedPoint = 19;

        lives.Lives = 5;

        // Using the get; part of the properties
        print($"The score is {score.Point}");
        print($"The real restricted score is {restrictedScoreReal.RestrictedPoint}");
        print($"The fake restricted score is {restrictedScoreDefault.RestrictedPoint}");
        
        print($"The amount of lives is {lives.Lives}");
    }
}
