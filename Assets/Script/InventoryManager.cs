using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    //public InventoryItemController[] InventoryItems;
    private List<InventoryItemController> InventoryItems = new List<InventoryItemController>();

    void Awake()
    {
        Instance = this; 
    }

    // Metodo per aggiungere Item alla lista
    public void Add(Item item)
    {
        Items.Add(item);
        ListItem();
    }

    //Metodo per rimuovere Item dalla lista
    public void Remove(Item item)
    {
        Items.Remove(item);
        ListItem();
    }

    public void CleanList()
    {
        //Pulisce la lista prima di aprire l'inventario
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
        InventoryItems.Clear();
    }

    //Metodo che aggiunge all'inventario nome e sprite dell'item raccolto
    public void ListItem()
    {
        //Pulisce la lista prima di aprire l'inventario
        CleanList();

        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;

            // Aggiunge il componente InventoryItemController e lo inizializza
            InventoryItemController itemController = obj.GetComponent<InventoryItemController>();
            if (itemController != null)
            {
                itemController.AddItem(item);
                InventoryItems.Add(itemController); // Tiene traccia degli oggetti reali
            }
        }
    }

}
