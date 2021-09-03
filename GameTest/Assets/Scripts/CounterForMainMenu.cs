using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterForMainMenu : MonoBehaviour
{
    public static CounterForMainMenu Instance { get; private set; }
    public int countLoad;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
}
