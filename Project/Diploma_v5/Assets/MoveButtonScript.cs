using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtonScript : MonoBehaviour {

    public void OnSelect()
    {
        GameObject menu = this.transform.parent.gameObject;
        GameObject light = menu.transform.parent.gameObject;
        MoveLight move = light.GetComponent<MoveLight>();
        move.Awake();

        
    }
}
