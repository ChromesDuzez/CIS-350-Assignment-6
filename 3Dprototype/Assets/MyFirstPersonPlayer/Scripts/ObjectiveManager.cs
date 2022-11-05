/*
 * Zach Wilson
 * Assignment 5B
 * This is the Objective Manager Script and it gets attached to the Goal Pickup Item and handles the trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveManager : MonoBehaviour
{
    public Text errorText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && (Globals.objectivesLeft <= 0))
        {
            Globals.objectiveComplete = true;
            Destroy(gameObject);
        }
        else if(other.CompareTag("Player") && (Globals.objectivesLeft != 0))
        {
            errorText.text = "There are still pink cubes to be destroyed!";
        }
    }

    private void Update()
    {
        if(Globals.objectivesLeft <= 0 && errorText.text != "")
        {
            errorText.text = "";
        }
    }
}
