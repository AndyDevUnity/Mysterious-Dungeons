using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    [Header("Movement")]
    private CharacterController _heroController;
    private float _speed = 4.5f;

    [SerializeField]
    [Header("Gravitation")]
    private Vector3 _velocity;
    [SerializeField] private Transform _checkGround;
    [SerializeField] private LayerMask _groundLayer;
    private float _groundDistance = 0.5f;
    private float _gravity = -18;
    private bool _isGround;

    private void Awake()
    {
        _heroController = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        Run();
    }

    private void Run()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * horizontal + transform.forward * vertical;
        _heroController.Move(direction * _speed * Time.deltaTime);
    }

    private void CheckGround()
    {
        _velocity.y += _gravity * Time.deltaTime;
        _heroController.Move(_velocity * Time.deltaTime);

        _isGround = Physics.CheckSphere(_checkGround.position, _groundDistance, _groundLayer);
        if (_isGround && _velocity.y < 0)
        {
            _velocity.y -= 1f;
        }
    }
}
