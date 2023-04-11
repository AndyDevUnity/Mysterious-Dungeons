using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private GameObject _description;
    [SerializeField] private TMP_Text _descriptionText;
    [SerializeField] private float _hitRange;

    private void Update()
    {
        InteractionRay();
    }

    private void InteractionRay()
    {
        Ray ray = _mainCamera.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitRegisterd = false;
        if (Physics.Raycast(ray, out hit, _hitRange))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                hitRegisterd = true;
                _descriptionText.text = interactable.Description();

                if (Input.GetKeyDown(KeyCode.E))
                    interactable.Interact();
            }
        }
        _description.SetActive(hitRegisterd);
    }
}
