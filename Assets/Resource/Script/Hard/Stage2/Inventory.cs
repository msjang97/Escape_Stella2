using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<SlotData> slots = new List<SlotData>();
    private int MaxSlot = 5;
    public GameObject SlotPrefab;

    private void Start()
    {
        GameObject slotPanel = GameObject.Find("Panel");

        for (int i = 0; i < MaxSlot; i++)
        {
            GameObject go = Instantiate(SlotPrefab, slotPanel.transform, false);
            go.name = "Slot_" + i ;
            SlotData Slot = new SlotData();
            Slot.isEmpty = true;
            Slot.SlotObj = go;
            slots.Add(Slot);
        }
    }
}
