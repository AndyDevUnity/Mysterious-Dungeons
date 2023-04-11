using UnityEngine;

public class TorchUsage : MonoBehaviour, IInteractable
{
    [SerializeField] private Light _light;
    [SerializeField] private bool _isOn;

    void Start()
    {
        _light.enabled = _isOn;
    }

    public string Description()
    {
        if (_isOn)
            return "����� [E] ����� <color=red>��������</color> �����!";
        return "����� [E] ����� <color=green>������</color> �����!";
    }

    public void Interact()
    {
        _isOn = !_isOn;
        _light.enabled = _isOn;
    }
}
