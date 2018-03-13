using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

/// <summary>
/// Called by PlaySpaceManager after planes have been generated from the Spatial Mapping Mesh.
/// This class will create a collection of prefab objects that have the 'Placeable' component and
/// will attempt to set their initial location on planes that are close to the user.
/// </summary>
public class StartAction : Singleton<StartAction>
{

    [Tooltip("A collection of Placeable space object prefabs to generate in the world.")]
    public GameObject spaceObjectPrefab;
    public int globalCount;

    public void Start() {

        Instantiate(spaceObjectPrefab);
        globalCount++;
    }
    
}
        

