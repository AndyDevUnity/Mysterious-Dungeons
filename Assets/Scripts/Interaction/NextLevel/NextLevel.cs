using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour, IInteractable
{
    public string Description()
    {
        return "����� [E] ����� <color=green>����������</color>!";
    }
    public void Interact()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
