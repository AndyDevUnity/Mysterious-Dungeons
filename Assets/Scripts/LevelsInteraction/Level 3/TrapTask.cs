using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapTask : MonoBehaviour
{
    [SerializeField] private GameObject _deathInfoPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            _deathInfoPanel.SetActive(true);
        }
    }

    public void TryAgain() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
