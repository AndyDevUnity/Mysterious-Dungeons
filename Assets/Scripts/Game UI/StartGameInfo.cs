using UnityEngine;

public class StartGameInfo : MonoBehaviour
{
    [SerializeField] private GameObject _gameInfo;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void ClosePanelInfo()
    {
        _gameInfo.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
