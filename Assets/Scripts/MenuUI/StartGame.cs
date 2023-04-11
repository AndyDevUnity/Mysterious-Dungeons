using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void LoadGameScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
