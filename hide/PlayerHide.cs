using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHide : MonoBehaviour
{
    public GameObject hideFadeEffect;
    public bool hideStart = false;

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     //if(hideStart == true)
    //     //{
    //         if(other.CompareTag("Hide"))
    //         {
    //             Invoke("HideEnter", 0.5f);
    //             hideStart = true;
    //             Debug.Log("hide");
    //         }
    //     //}
    // }

    public void HideEnter()
    {
        hideStart = true;
        PlayerMouseControll.instance.StopMove();
        hideFadeEffect.GetComponent<FadeIn>().Fade();
        Debug.Log("fade");
    }
}
