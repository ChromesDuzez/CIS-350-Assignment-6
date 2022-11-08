using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    #region This code makes a class that extends it a singleton
    private static T instance;

    public static T Instance
    {
        get { return instance; }
    }

    public static bool IsInitialized
    {
        get { return instance != null; }
    }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("[Singleton] Trying to instantiate a second instance of a singleton class");
        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        //if this object is destroyed, make instance null so another could be created
        if(instance == this)
        {
            instance = null;
        }
    }
    #endregion
}
