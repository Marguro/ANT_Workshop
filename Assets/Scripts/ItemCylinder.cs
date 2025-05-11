using UnityEngine;

public class ItemCylinder : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Debug.Log("Interact item : Cylinder");
    }
}
