using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BooksUsage : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject _bookPanel;
    [SerializeField] private TMP_Text _bookText;
    [SerializeField] private GameObject _key;

    public string Description()
    {
        return "Нажми [Е] чтобы <color=green>прочесть</color> книгу!";
    }

    public void Interact()
    {
        _animator.SetBool("isOpen", true);
        _bookPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        ChoiceBookText();
    }

    private void ChoiceBookText()
    {
        var books = new BooksText();

        switch (SceneManager.GetActiveScene().name)
        {
            case "MainLevel":
                _bookText.text = books.GetBookText(0);
                _key.SetActive(true);
                break;
            case "Level_1":
                _bookText.text = books.GetBookText(1);
                break;
            case "Level_2":
                _bookText.text = books.GetBookText(2);
                break;
            case "Level_3":
                _bookText.text = books.GetBookText(3);
                break;
            case "Level_4":
                _bookText.text = books.GetBookText(4);
                break;
            case "Level_5":
                _bookText.text = books.GetBookText(5);
                break;
            case "Level_6":
                _bookText.text = books.GetBookText(6);
                break;
            case "Level_7":
                _bookText.text = books.GetBookText(7);
                break;
            case "Level_8":
                _bookText.text = books.GetBookText(8);
                break;
            case "Level_9":
                _bookText.text = books.GetBookText(9);
                break;
        }
    }

    public void CloseBook()
    {
        _bookPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
