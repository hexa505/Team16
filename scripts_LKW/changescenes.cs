using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescenes : MonoBehaviour
{
    // Start is called before the first frame update

    public static string PreviousScene = "";

    public void ChangeScene(string sceneName)
    {
        PreviousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }
    
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene(PreviousScene);
    }
    public void QuitApp()
    {
        Application.Quit();
    }

}
