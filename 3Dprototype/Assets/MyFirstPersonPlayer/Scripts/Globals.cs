/*
 * Zach Wilson
 * Assignment 5B
 * This is the Gloabls script and I use it to store global variables i want to be able to access from any script
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    GameObject[] objectives;
    public static int objectivesLeft;

    public static bool objectiveComplete = false;

    void Update()
    {
        objectives = GameObject.FindGameObjectsWithTag("Objectives");
        objectivesLeft = objectives.Length;

        if (objectivesLeft > 0)
        {
            objectiveComplete = false;
        }
    }
}
