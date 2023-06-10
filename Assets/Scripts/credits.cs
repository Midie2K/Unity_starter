using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public void exit(){
        Application.Quit();
    }

    public void backToGameMenu(){
        SceneManager.LoadScene(sceneBuildIndex:1);
    }
}
