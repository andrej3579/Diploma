using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveButtonScript : MonoBehaviour {

    public void OnSelect()
    {
        //GameObject.Find("LightMenu").SetActive(false);
        //Najdi ultimate parenta(luč) in  ga Destroy(luč)
        
            GameObject menu = this.transform.parent.gameObject;
            Destroy(menu.transform.parent.gameObject);
            StartAction.Instance.globalCount -= 1;
        if (StartAction.Instance.globalCount < 1)
        {
            StartAction.Instance.Start();
        }

    }
}
