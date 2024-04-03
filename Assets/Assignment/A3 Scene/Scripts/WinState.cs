using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinState : Mice
{
    // Start is called before the first frame update
    public void WinScreen()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(3); // % modular leaves remainder 
    }
    //when player hits mountain it will trigger the winscreen. 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        WinScreen();
    }
}
