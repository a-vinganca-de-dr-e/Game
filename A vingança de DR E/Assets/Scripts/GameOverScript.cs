using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        score = PlayerPrefs.GetInt("Score");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

        GUI.Label(new Rect(Screen.width / 2 - 40, 150, 80, 30), "Score: " + score);

        if(GUI.Button(new Rect(Screen.width / 2 -30, 200, 60, 30), "Retry?"))
        {
            Application.LoadLevel(0);
        }
    }
}
