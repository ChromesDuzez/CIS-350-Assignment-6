/*
 * Zach Wilson
 * Assignment 5B
 * This is the game over screen manager it handles the game over screen and the restarting of the level
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreenManager : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Globals.objectiveComplete)
        {
            try
            {
                gameObject.GetComponent<Text>().text = "Game Over" + "\n" + "You Win!" + "\n" + "Press R to Restart.";
            }
            catch
            {
                Debug.LogError("GameOverScreenManager.cs not attached to TextObject");
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                gameObject.GetComponent<Text>().text = "";
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
