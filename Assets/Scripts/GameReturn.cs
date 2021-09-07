using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReturn : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadSceneAsync(0);
        SceneManager.UnloadSceneAsync(1);
    }
}
