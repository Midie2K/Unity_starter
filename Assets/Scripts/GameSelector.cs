using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelector : MonoBehaviour
{
    public void startSlider(){
        SceneManager.LoadScene("slider_LVL01");
    }

    public void start3DPlatform(){
        SceneManager.LoadScene("Platform_LVL1");
    }
}
