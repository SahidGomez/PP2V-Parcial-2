using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public int ActiveSlot = 0;
    public Transform Slots;
    public Transform[] InventorySlot;
    
    // Start is called before the first frame update
    void Start()
    {
        InventorySlot = Slots.GetComponentsInChildren<Transform>();
        InventorySlot[ActiveSlot].GetChild(0).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        InventorySlot[ActiveSlot].GetChild(0).gameObject.SetActive(true) ;
    }
}
