using UnityEngine;

public class InteractableCube : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.LogWarning("Cube");
    }
}
