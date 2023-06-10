using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour{

    public float restartDelay = 2f;
    bool GameOverTriggered = false;
    public GameObject completeLevelUI;

    public void completeLVL(){
        completeLevelUI.SetActive(true);
    }
    public void GameOver(){
        if(!GameOverTriggered){
            GameOverTriggered = true;  
            Debug.Log("GAME OVER");
            Invoke("Restart",restartDelay);
        }
    }
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
