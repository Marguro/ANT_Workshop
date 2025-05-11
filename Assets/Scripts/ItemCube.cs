using UnityEngine;

public class ItemCube : MonoBehaviour,IInteractable
{
    public void Interact()
    {
        Debug.Log("Interact item : Cube");
    }
    
}
