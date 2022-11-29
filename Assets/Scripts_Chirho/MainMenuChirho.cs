using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuChirho : MonoBehaviour
{
    public void PlayChirho()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitPlayChirho()
    {
        Application.Quit();
    }
}
