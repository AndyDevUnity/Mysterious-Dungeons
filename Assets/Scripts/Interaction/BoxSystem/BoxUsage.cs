using UnityEngine;

public class BoxUsage : MonoBehaviour, IInteractable
{
    private Rigidbody _rigidbody;
    [SerializeField] private bool _canTakeBox;
    [SerializeField] private Transform _position;
    [SerializeField] private HandController _handController;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _canTakeBox = true;
    }

    private void Update()
    {
        if (_rigidbody.isKinematic == true)
            this.gameObject.transform.position = _position.position;

        DropBox();
    }

    public string Description()
    {
        if (_canTakeBox)
            return "Нажми [Е] чтобы <color=green>поднять</color> ящик!";
        return "Нажми [G] чтобы <color=red>положить</color> ящик!";
    }

    public void Interact()
    {
        if (_canTakeBox && _handController.HandBusy)
        {
            _rigidbody.isKinematic = true;
            _rigidbody.MovePosition(_position.position);
            _canTakeBox = false;
            _handController.HandBusy = false;
        }
    }

    private void DropBox()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _rigidbody.useGravity = true;
            _rigidbody.isKinematic = false;
            _canTakeBox = true;
            _handController.HandBusy = true;
        }
    }
}
