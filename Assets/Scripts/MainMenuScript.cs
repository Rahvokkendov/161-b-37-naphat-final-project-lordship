using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [field: SerializeField] protected AudioSource clickPop;
    public void ButtonStart()
    {
        SceneManager.LoadScene("MainScene");
        clickPop.Play();
    }

    public void ButtonQuit() 
    { 
        Application.Quit();
        clickPop.Play();
    }

}
