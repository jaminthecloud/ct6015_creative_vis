using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOver : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    public GameObject HoverElements;
    public void OnPointerEnter(PointerEventData eventData)
    {
        HoverElements.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
      HoverElements.SetActive(false);
    }

}
