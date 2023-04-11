using UnityEngine;
using TMPro;

public class AnswerTask : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _infoPanel;
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private GameObject _key;

    private bool _isGuessed = false;

    public string Description()
    {
        if (_isGuessed == false)
            return "<color=green>??????</color>";
        return null;
    }

    public void Interact()
    {
        Cursor.lockState = CursorLockMode.None;
        _infoPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        _infoPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        if (_inputField.text == "2" && _key != null)
        {
            _key.SetActive(true);
            _isGuessed = true;
        }
    }
}
