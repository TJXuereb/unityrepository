using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads next level
    }

    public void LoadLevel(string levelName)
    {
        print("Loading level " + levelName);
        //loads the Scene named levelName
        SceneManager.LoadScene(levelName);
    }


    public void QuitGame() //quits the game
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }





}
