using UnityEngine;

public class DoorUsage : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    [SerializeField] private bool _isOpen = false;
    [SerializeField] private BoxCollider _collider;

    private void Start()
    {
        KeyUsage.keyReceived += CheckKey;
    }

    public string Description()
    {
        if (_isOpen == false)
            return "����� <color=red>�������</color>, ����� ����!";
        return "����� [E] ����� <color=green>�������</color> �����!";
    }

    public void Interact()
    {
        if (_isOpen)
        {
            animator.SetBool("isOpen", true);
            _collider.enabled = false;
        }
        else
            animator.SetBool("isOpen", false);
    }

    private void CheckKey() => _isOpen = true;
}