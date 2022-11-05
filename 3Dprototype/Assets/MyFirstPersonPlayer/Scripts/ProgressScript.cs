/*
 * Zach Wilson
 * Assignment 5B
 * This is the progress script and it gets attached to a textbox for the HUD
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressScript : MonoBehaviour
{
    public Text textBox;

    // Update is called once per frame
    void Update()
    {
        textBox.text = Globals.objectivesLeft + " Objectives Left";

        if (Globals.objectivesLeft <= 0)
        {
            textBox.text = "Head to the Goal";
        }
    }
}
