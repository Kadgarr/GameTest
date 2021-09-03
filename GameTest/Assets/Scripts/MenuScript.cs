using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvasMenu;
    public GameObject menuCount;
    CounterForMainMenu count;

    private void Awake()
    {
        
        count = menuCount.GetComponent<CounterForMainMenu>();
        if (count.countLoad >= 1)
        {
            Debug.Log("TRUE");
            this.gameObject.SetActive(false);
        }
    }
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
