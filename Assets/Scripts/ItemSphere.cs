using UnityEngine;

public class ItemSphere : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Debug.Log("Interact item : Sphere");
    }
}
