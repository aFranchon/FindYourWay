using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScr : MonoBehaviour
{
    public void quitButton()
    {
        Application.Quit();
    }

    public void playButton()
    {
        SceneManager.LoadScene("Game");
    }
}
