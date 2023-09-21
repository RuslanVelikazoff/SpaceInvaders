using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelUIManager : MonoBehaviour
{
    public Button exitLevelButton;

    public GameObject LosePanel;
    public Button exitButton;
    public Button restartButton;

    private void Start()
    {
        ExitLevel();
        LossePanel();
    }

    private void ExitLevel()
    {
        if (exitLevelButton != null)
        {
            exitLevelButton.onClick.RemoveAllListeners();
            exitLevelButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(0);
            });
        }
    }

    private void LossePanel()
    {
        if (exitButton != null)
        {
            exitButton.onClick.RemoveAllListeners();
            exitButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(0);
            });
        }

        if (restartButton != null)
        {
            restartButton.onClick.RemoveAllListeners();
            restartButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            });
        }
    }
}
