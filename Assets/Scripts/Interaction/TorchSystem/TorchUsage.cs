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
            return "Нажми [E] чтобы <color=red>потушить</color> факел!";
        return "Нажми [E] чтобы <color=green>зажечь</color> факел!";
    }

    public void Interact()
    {
        _isOn = !_isOn;
        _light.enabled = _isOn;
    }
}
