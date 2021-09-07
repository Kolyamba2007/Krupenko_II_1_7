using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadGameScene(int e)
    {
        SceneManager.LoadSceneAsync(e);

        Time.timeScale = 1;
        DebugManager.Log("Level loaded.");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
