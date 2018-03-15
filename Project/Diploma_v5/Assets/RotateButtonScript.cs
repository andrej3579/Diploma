using System.Collections;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.VR.WSA.Input;

public class RotateButtonScript : MonoBehaviour
    {

    public void OnSelect()
    {
        GameObject menu = this.transform.parent.gameObject;
        //print(menu.name);
        GameObject light = menu.transform.parent.gameObject;
        //print(light.name);
        GameObject head = light.transform.GetChild(0).gameObject;
        //print(head.name);
        RotateLight rotate = head.GetComponent<RotateLight>();
        //print(rotate.name);
        if (rotate.enabled != true)
            rotate.enabled = true;
        else
        {
            rotate.OnPlacementStart();
        }
    



        // RotateLight.Instance.Start();
        //RotateLight rotate = gameObject.GetComponent<RotateLight>();
    }



}

