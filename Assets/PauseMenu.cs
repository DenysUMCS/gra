using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenuUI;
    public static bool isPause;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        	if(isPause)
        		Resume();
        	else Pause_();
        }
    }
    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale= 1f;
        isPause = false;
    }
    void Pause_(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPause = true;
    }
}
