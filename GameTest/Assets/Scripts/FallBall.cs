using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBall : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenu;
    public GameObject background;
  

 
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            pauseMenu.SetActive(true);
            background.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
