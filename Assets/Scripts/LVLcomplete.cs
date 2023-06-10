
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVLcomplete : MonoBehaviour
{
    public void LoadNextLVL(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
