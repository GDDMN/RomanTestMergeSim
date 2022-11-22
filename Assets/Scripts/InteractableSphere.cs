using UnityEngine;

public class InteractableSphere : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.LogError("Sphere");
    }
}
