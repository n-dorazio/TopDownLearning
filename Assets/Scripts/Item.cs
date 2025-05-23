using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int ID;
    public string Name;


    public virtual void UseItem()
    {
        Debug.Log("Using item " + Name);
    }

    public virtual void PickUp()
    {
        Sprite itemIcon = GetComponent<Image>().sprite;
        if(ItemPickupUiController.Instance != null)
        {
            ItemPickupUiController.Instance.ShowItemPickup(Name, itemIcon);
        }
    }
}
