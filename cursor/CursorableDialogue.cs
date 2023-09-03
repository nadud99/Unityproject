using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider2D))]

public class CursorableDialogue : MonoBehaviour
{
    public void OnMouseEnter() 
    {
        //CursorController.instance.Dialogue_Click();
        CursorController.instance.Default();
    }

    public void OnMouseExit() 
    {
        CursorController.instance.Default();
    }
}
