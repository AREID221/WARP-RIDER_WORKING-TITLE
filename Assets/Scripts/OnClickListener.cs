using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OnClickListener : MonoBehaviour, IPointerClickHandler
{
    
    public Button Lbutton;
    public Button Rbutton;
    public PlayerController playerControls;
    public bool moving = false;
    private void Awake()
    {
        
        Lbutton.onClick.AddListener(OnClickActiveL);
        Rbutton.onClick.AddListener(OnClickActiveR);
    }
    public void OnClickActiveL()
    {
        playerControls.PlayerMove(false);
        Debug.Log("move left");

    }
    public void OnClickActiveR()
    {
        playerControls.PlayerMove(true);
        Debug.Log("move right");

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.pointerEnter == true)
        {

        }
    }
}
