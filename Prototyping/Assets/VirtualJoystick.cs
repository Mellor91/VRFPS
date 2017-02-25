using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class VirtualJoystick : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{

    private Image joyBG;
    private Image joyIMG;

    public Vector3 inputDirection { set; get; }

    // Use this for initialization
    void Start()
    {
        joyBG = GetComponent<Image>();
        joyIMG = transform.GetChild(0).GetComponent<Image>();
        inputDirection = Vector3.zero;
    }


    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos = Vector2.zero;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle
            (joyBG.rectTransform, eventData.position, eventData.pressEventCamera, out pos))
        {
            pos.x = pos.x / joyBG.rectTransform.sizeDelta.x;
            pos.y = pos.y / joyBG.rectTransform.sizeDelta.y;

            float x = (joyBG.rectTransform.pivot.x == 1) ? pos.x * 2 + 1 : pos.x * 2 - 1;
            float y = (joyBG.rectTransform.pivot.y == 1) ? pos.y * 2 + 1 : pos.y * 2 - 1;

            inputDirection = new Vector3(x , 0, y );

            inputDirection = (inputDirection.magnitude > 1) ? inputDirection.normalized : inputDirection;

            joyIMG.rectTransform.anchoredPosition = new Vector3(
                inputDirection.x * (joyBG.rectTransform.sizeDelta.x / 3),
                inputDirection.z * (joyBG.rectTransform.sizeDelta.y / 3));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputDirection = Vector3.zero;
        joyIMG.rectTransform.anchoredPosition = Vector3.zero;
    }





}
