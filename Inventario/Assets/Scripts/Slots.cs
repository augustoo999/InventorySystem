using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slots : MonoBehaviour, IDropHandler
{
    public ItemType SlotType;
    public bool isInventory = false;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag.GetComponent<Item>().ItemType != SlotType && !isInventory)
        {
            return;
        }

        if (transform.childCount == 0)
        {
            var dropped = eventData.pointerDrag;
            var draggableItem = dropped.GetComponent<Drag>();
            draggableItem.ParentAfDrag = transform;
        }
        else if (transform.childCount == 1 && eventData.pointerDrag.GetComponent<Item>().ItemType == SlotType && !isInventory)
        {
            var draggableItem = eventData.pointerDrag.GetComponent<Drag>();
            var initialSlot = draggableItem.ParentAfDrag;
            var destinySlot = transform.GetChild(0).GetComponent<Drag>().ParentAfDrag;

            transform.GetChild(0).SetParent(initialSlot);
            draggableItem.ParentAfDrag = destinySlot;
        }
    }
}
