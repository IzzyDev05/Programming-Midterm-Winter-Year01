/*
A singleton pattern is a design pattern used when you only want 1 instance (version) of a particular class throughout the entirety of the software/game.
I make use of this in the audio manager script I use in all my games (Thanks Brackeys).
*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class OnlyOne : MonoBehaviour
{
    // static means this variable belongs to the CLASS ITSELF and NOT an instance (version) of the class.
    public static OnlyOne instance;

    private void Awake() {
        /*
        if there exists no version of this script,
            make an instance of this script
        else (there already exists a version of the OnlyOne script during runtime),
            delete this instance of the script
        
        When changing scenes, don't destroy this game object (Carry it over into the new scene)
        */

        if (instance == null) {
            instance = this;
        }
        else {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            SceneManager.LoadScene(1);
        }
    }
}