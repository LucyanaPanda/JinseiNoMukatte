
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameButtonsHandler : MonoBehaviour
{
    Scene scene;
    [SerializeField] private GameObject _credits;
    [SerializeField] private GameObject _settings;

    [SerializeField] private Button _quitCredits;
    [SerializeField] private Button _quitSettings;

    public void ShowMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void ShowLevels()
    {
        SceneManager.LoadScene(1);
    }
    public void PlayLevel1()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayLevel3()
    {
        SceneManager.LoadScene(4);
    }
    public void ShowCredits()
    {
        
    }
    public void Retry()
    {
       scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
