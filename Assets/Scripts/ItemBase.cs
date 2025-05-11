using UnityEngine;

public class ItemBase : MonoBehaviour ,IInteractable
{
    public ItemData data;
    
    public void Interact()
    {
        Debug.Log("Interact ite : " + data.itemName);
        InventoryManager.instance.AddItem(data);
        Destroy(gameObject);
    }
}
