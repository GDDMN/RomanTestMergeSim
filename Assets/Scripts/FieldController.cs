using UnityEngine;

public class FieldController : MonoBehaviour
{
    [SerializeField] private AnimationCurve _curve;
    [SerializeField] private BoxCollider _collider;


    private void OnCollisionEnter(Collision other)
    {
        IInteractable otherObject = other.gameObject.GetComponent<IInteractable>();
        if (otherObject == null)
            return;

        otherObject.Interact();
    }
}



