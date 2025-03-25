using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    Item item;

    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);

        Destroy(gameObject);
    }

    //Aggiunge l'item rimosso dalla scena all'inventario 
    public void AddItem(Item newItem)
    {
        item = newItem;
    }

    //Usa l'item nell'inventario aggiornando la ui e poi lo rimuove
    public void UseItem()
    {
        switch (item.itemType)
        {
            case Item.ItemType.Health_Potion:
                PlayerController.Instance.IncreaseHealth(item.value);
                break;
            case Item.ItemType.Mana_Potion:
                PlayerController.Instance.IncreaseMana(item.value);
                break;
            case Item.ItemType.Book:
                PlayerController.Instance.IncreaseExp(item.value);
                break;
        }

        RemoveItem();
    }
}
