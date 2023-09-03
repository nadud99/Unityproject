using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class ClickableHide : MonoBehaviour
{
    public void OnMouseEnter() 
    {
        //CursorController.instance.Hide_Click();  
        CursorController.instance.Default();
    }

    public void OnMouseExit() 
    {
        CursorController.instance.Default();
    }
}
