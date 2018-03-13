using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButtonScript : MonoBehaviour {
         public void OnSelect()
    {
        // GameObject.Find("LightMenu").SetActive(false);
        /*Najdi parenta in ga SetActive(false); */
        this.transform.parent.gameObject.SetActive(false);


    }
}
