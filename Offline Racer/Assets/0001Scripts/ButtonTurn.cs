using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTurn : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject player;
    public string message;
    public bool ispressed = false;

    void OnEnable()
    {
        ispressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ispressed == true)
            player.SendMessage(message);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
}

