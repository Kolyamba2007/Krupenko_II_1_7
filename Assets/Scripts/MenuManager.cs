using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void LoadGameScene(int e)
    {
        var r = SceneManager.LoadSceneAsync(e);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
