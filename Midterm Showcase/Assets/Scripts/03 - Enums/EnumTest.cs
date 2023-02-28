/*
An enum is basically a custom datatype. It can make life easier in a lot of places, but you most probably won't use them in small projects.
I use this for a turn-based multiplayer script I created. Other uses could be weapon types, potions, etc.
*/

using UnityEngine;

public class EnumTest : MonoBehaviour
{
    enum GameState {Ready, Playing, Pause, GameOver};
    // These don't only have the name we give them, but they also have int values (Ready is 0, Playing is 1, etc.)

    [SerializeField] private GameState state;

    private void Update() {
        // I originally used an if statement, but the prof used a switch because in this case, it's syntax is easier.
        // I'm also now going to use a switch statement so I can remind you guys that it exists.

        switch (state) {
            case GameState.Ready:
                print("The game is ready!");
                break;
            case GameState.Playing:
                print("The game is playing!");
                break;
            case GameState.Pause:
                print("The game is paused!");
                break;
            case GameState.GameOver:
                print("The game is over!");
                break;
        }
    }
}