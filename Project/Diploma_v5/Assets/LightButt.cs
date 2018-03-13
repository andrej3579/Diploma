using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButt : MonoBehaviour {

    public void OnSelect()
    {
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);

    }

    public void OnClick()
    {
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);

    }
}
