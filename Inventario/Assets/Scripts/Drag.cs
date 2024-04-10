using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler
{
    public Image Image;
    [HideInInspector] public Transform ParentAfDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        ParentAfDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        Image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(ParentAfDrag);
        Image.raycastTarget = true;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        var item = gameObject.GetComponent<Item>();
        FindObjectOfType<>
    }
}
