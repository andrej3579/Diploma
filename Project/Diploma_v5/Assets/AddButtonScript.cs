using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class AddButtonScript : Singleton<AddButtonScript>
{

    [Tooltip("A collection of Placeable space object prefabs to generate in the world.")]
    public GameObject spaceObjectPrefab;
    public void OnSelect()
    {
        Instantiate(spaceObjectPrefab);
        StartAction.Instance.globalCount += 1 ;
    }
}
