using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    

    public GameObject startMenu;
    
    
    private void Start()
    {
        
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        Time.timeScale = 1f;
       
    }

    public void Exit()
    {
        Application.Quit();
    }
}
