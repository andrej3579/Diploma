using Academy.HoloToolkit.Unity;
using UnityEngine;

public class Rotation : Singleton<Rotation>
{
    public bool IsRotating { get; private set; }

    private Vector3 lastCamPosition;

    // Speed (1.0 being fastest) at which the object settles to the surface upon placement.
    private float placementVelocity = 0.06f;

    // The location at which the object will be placed.
    private Vector3 targetPosition;

    public void Start()
    {
        print("In Rotation");
        lastCamPosition = Camera.main.transform.position;

        if (!IsRotating)
        {
            OnPlacementStart();
        }
        else
        {
            OnPlacementStop();
        }
    }

    private void Update()
    {
        /* TODO: 4.a CODE ALONG 4.a */
        print("Update");
        if (IsRotating)
        {
            // Rotate the object.
            print("UpdateCallRotate");
            Rotate();
        }
        else
        {
            print("UpdateDisableFunction");
            gameObject.transform.rotation = gameObject.transform.rotation;
            gameObject.GetComponent<Rotation>().enabled = false;
        }
    }

    void Tap() {
        print("In tap");
        OnPlacementStop();
    }



    public void OnPlacementStart()
    {
 
        //GestureManager.Instance.OverrideFocusedObject = gameObject;

        IsRotating = true;
        print("OnPlacementStart");
    }

    /// <summary>
    /// Take the object out of placement mode.
    /// </summary>
    /// <remarks>
    /// This method will leave the object in placement mode if called while
    /// the object is in an invalid location.  To determine whether or not
    /// the object has been placed, check the value of the IsPlacing property.
    /// </remarks>
    public void OnPlacementStop()
    {
        // ValidatePlacement requires a normal as an out parameter.
        // Check to see if we can exit placement mode.

        // The object is allowed to be placed.
        // We are placing at a small buffer away from the surface.
        

        //GestureManager.Instance.OverrideFocusedObject = null;

        // Exit placement mode.
        IsRotating = false;
        print("OnPlacementStop");
    }

    /// <summary>
    /// Positions the object along the surface toward which the user is gazing.
    /// </summary>
    /// <remarks>
    /// If the user's gaze does not intersect with a surface, the object
    /// will remain at the most recently calculated distance.
    /// </remarks>
    private void Rotate()
    {
        print("RotateStart");
        //preveri zadnjo pozicijo kamere
        float rotX = Camera.main.transform.position.x - lastCamPosition.x;
        float rotY = Camera.main.transform.position.y - lastCamPosition.y;

        gameObject.transform.rotation = Quaternion.Euler(rotX, rotY, 0f);

        lastCamPosition = Camera.main.transform.position;
        print("RotateStop");
    }
}





