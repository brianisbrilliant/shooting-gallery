using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public bool buttonIsBad = true;

    public void Pressed() {
        if(buttonIsBad) {
            Debug.Log("We've destroyed a bad button.");
        } else {
            Debug.Log("Oh No! We've destroyed a good button.");
        }
        Destroy(this.gameObject);
    }
}
