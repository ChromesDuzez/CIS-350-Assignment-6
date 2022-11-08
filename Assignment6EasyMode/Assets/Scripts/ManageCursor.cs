using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageCursor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GameManager.paused)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
