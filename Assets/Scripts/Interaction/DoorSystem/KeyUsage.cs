using System;
using UnityEngine;

public class KeyUsage : MonoBehaviour, IInteractable
{
    internal static Action keyReceived;

    public string Description()
    {
        return "������� [E] ����� ����� ����!";
    }
    public void Interact()
    {
        keyReceived?.Invoke();
        Destroy(this.gameObject);
    }
}
