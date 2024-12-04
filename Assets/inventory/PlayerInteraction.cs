using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.ComponentModel;

public class PlayerInteraction : MonoBehaviour
{
    public OBjects inventory;
    [SerializeField] private GameObject inventorydisplay;
    // Start is called before the first frame update
    public void pickupobject(Collider other)
    {
        //var item = other.GetComponent<GroundItem>();
        var item2 = other.GetComponent<GroundObjects>();
        if (item2)
        {
            Item _item = new Item(item2.item);
            if (!isfull() || inventory.checkstack(_item))
            {
                Debug.Log(_item.Id);
                inventory.AddItem(_item, item2.amount);
                Destroy(other.gameObject);
            }
            else { Debug.Log("nope"); }
        }
    }
    public bool isfull()
    {
        foreach (var slot in inventory.Container.Items)
        {
            Debug.Log(slot.ID);
            if (slot.ID < 0)
            {
                return false;
            }
        }
        return true;
    }
    public void OnTriggerEnter(Collider other)
    {
        pickupobject(other);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            inventory.Load();
        }
        if(Input.GetKeyDown(KeyCode.Tab)) 
        {
            if (inventorydisplay.activeInHierarchy == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
                inventorydisplay.SetActive(false);
            }
            else 
            { 
                inventorydisplay.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
            }

        }
    }
    private void OnApplicationQuit()
    {
        inventory.Container.Items = new InventorySlot[28];
    }
}
