using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    //Metodo che richiama il metodo di aggiunta di un Item e distrugge l'item nella scena
    void Pickup()
    {
        InventoryManager.Instance.Add(item);
        InventoryManager.Instance.ListItem();
        Debug.Log("Item raccolto: " +  item.ToString());
        Destroy(gameObject);
    }

    //Al click del mouse richiama il metodo Pickup()
    private void OnMouseDown()
    {
        Pickup();
    }
}
