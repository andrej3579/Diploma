using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class AddButtonScript : Singleton<AddButtonScript>
{
    //public GameObject spaceObjectPrefab;
    public void OnSelect()
    {
        Instantiate(StartAction.Instance.spaceObjectPrefab);
        StartAction.Instance.globalCount += 1 ;
    }
}
