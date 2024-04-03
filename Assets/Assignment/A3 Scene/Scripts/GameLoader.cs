using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadGame()
    {
        //Loads game screen after playerclicks button 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1); // % modular leaves remainder 


    }
    public void MainMenu()
    {
        //Menu screen after playerclicks button 
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(0); // % modular leaves remainder 

    }
   
}
