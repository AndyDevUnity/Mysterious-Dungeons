using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _player;
    private float _mouseSensetivity = 120f;
    private float _mouseX;
    private float _mouseY;
    private float _xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        _mouseX = Input.GetAxis("Mouse X") * _mouseSensetivity * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _mouseSensetivity * Time.deltaTime;
        _player.Rotate(Vector3.up * _mouseX);
        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -70f, 70f);
        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
    }
}