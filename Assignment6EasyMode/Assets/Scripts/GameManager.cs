using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : Singleton<GameManager>
{
    public int score;
    public static bool paused = false;
    public GameObject pauseMenu;
    
    //variable to keep track of what level we are on
    private string CurrentLevelName = string.Empty;

    #region This code handles the pause menu
    public void Pause()
    {
        Time.timeScale = 0f;
        paused = true;
        pauseMenu.SetActive(true);
    }
    public void Unpause()
    {
        Time.timeScale = 1f;
        paused = false;
        pauseMenu.SetActive(false);
    }
    #endregion

    #region This unused code used to make this class a singleton now we just extend our singleton script
    /*public static GameManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            //Make sure this game manager persists across scenes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second instance of singleton Game Manager");
        }
    }*/
    #endregion

    #region This bit of code handles the loading and unloading of scenes asyncronously
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName, LoadSceneMode.Additive);

        if(ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level " + levelName);
            return;
        }

        CurrentLevelName = levelName;
    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level " + levelName);
            return;
        }
    }

    public void UnloadCurrentLevel()
    {
        UnloadLevel(CurrentLevelName);
        Cursor.lockState = CursorLockMode.None;
    }
    #endregion

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (paused)
            {
                //Unpause();
            }
            else
            {
                Pause();
            }
        }
    }
}
