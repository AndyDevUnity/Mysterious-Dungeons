using UnityEngine;

public class QuizInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _taskPanel;

    public string Description()
    {
        return "<color=green>??????</color>";
    }

    public void Interact()
    {
        Cursor.lockState = CursorLockMode.None;
        _taskPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        _taskPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
