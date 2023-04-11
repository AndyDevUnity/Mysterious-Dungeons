using System;
using UnityEngine;

public class KeyUsage : MonoBehaviour, IInteractable
{
    internal static Action keyReceived;

    public string Description()
    {
        return "Нажмите [E] чтобы взять ключ!";
    }
    public void Interact()
    {
        keyReceived?.Invoke();
        Destroy(this.gameObject);
    }
}
