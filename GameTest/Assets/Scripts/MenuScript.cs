using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvasMenu;


 
    void Start()
    {
     
            Time.timeScale = 0f;
            canvasMenu.GetComponent<GameObject>();
        
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        this.gameObject.SetActive(false);
        canvasMenu.SetActive(false);
        
    }
    
}
