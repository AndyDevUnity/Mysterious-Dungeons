using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour, IInteractable
{
    public string Description()
    {
        return "Нажми [E] чтобы <color=green>продолжить</color>!";
    }
    public void Interact()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
