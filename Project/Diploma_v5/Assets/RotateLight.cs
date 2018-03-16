using Academy.HoloToolkit.Unity;
using UnityEngine;

public class RotateLight : MonoBehaviour
{
    public bool IsRotating { get; private set; }

    private Quaternion lastCamRotation;
    private float oldX;
    private float oldY;
    private GameObject tempCursor;
    // Speed (1.0 being fastest) at which the object settles to the surface upon placement.


    // The location at which the object will be placed.
    private Vector3 targetPosition;

    public void Start()
    {
        //print("In Rotation");
        // lastCamRotation = Camera.main.transform.rotation;
        tempCursor = GameObject.Find("Cursor");

        if (!IsRotating)
        {
            // oldX = Camera.main.ScreenToViewportPoint(Input.mousePosition).x;
            // oldY = Camera.main.ScreenToViewportPoint(Input.mousePosition).y;
            
            OnPlacementStart();

        }
        else
        {
            OnPlacementStop();
        }
    }

    void Tap() {
        if (IsRotating)
        {
            //print("InTap");
            OnPlacementStop();
        }
    }

    private void Update()
    {
        /* TODO: 4.a CODE ALONG 4.a */
        if (IsRotating)
        {
            // Rotate the object.
            Rotate();
        }
        else
        {
            //print("UpdateDisableFunction");
            gameObject.transform.rotation = gameObject.transform.rotation;
            //gameObject.GetComponent<Rotation>().enabled = false;
        }
    }


    public void OnPlacementStart()
    {

        //GestureManager.Instance.OverrideFocusedObject = gameObject;
        oldX = tempCursor.transform.position.x;
        oldY = tempCursor.transform.position.y;
        IsRotating = true;
        GameObject light = gameObject.transform.parent.gameObject;
        GameObject meni = light.transform.GetChild(2).gameObject;
        meni.SetActive(false);
        light.GetComponent<BoxCollider>().enabled = false;

        //print("OnPlacementStart");
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
        gameObject.transform.rotation = gameObject.transform.rotation;
        GameObject light = gameObject.transform.parent.gameObject;
        GameObject meni = light.transform.GetChild(2).gameObject;
        light.GetComponent<BoxCollider>().enabled = true;
        meni.SetActive(true);
        IsRotating = false;
        //print("OnPlacementStop");
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
        Vector3 position = tempCursor.transform.position;

        float camX = position.x;
        float camY = position.y;

        float rotY = camX - oldX;
        float rotX = camY - oldY;

        oldX = camX;
        oldY = camY;

        gameObject.transform.rotation = Quaternion.Euler(rotX * 150, -rotY * 150, 0f) * gameObject.transform.rotation;

        /*Vector3 position = GameObject.Find("Cursor").transform.position;
        gameObject.transform.LookAt(new Vector3(-180*position.x, -180 * position.y,0f ));*/
        /* //preveri zadnjo pozicijo kamere
         float rotX = Camera.main.transform.rotation.x - lastCamRotation.x;
         float rotY = Camera.main.transform.rotation.y - lastCamRotation.y;
         print("rotX " + rotX);
         print("rotY " + rotY);
         print("Cam " + Camera.main.transform.rotation);
         print("lastCam " + lastCamRotation);

         //transform.eulerAngles = gameObject.transform.rotation;

         gameObject.transform.rotation = Quaternion.Euler(rotX*10, rotY*10, 0f);

         lastCamRotation = Camera.main.transform.rotation;*/

        /*
        float camX = Camera.main.ScreenToViewportPoint(Input.mousePosition).x;
        float camY = Camera.main.ScreenToViewportPoint(Input.mousePosition).y;

        float rotY = camX - oldX;
        float rotX = camY - oldY;

        oldX = camX;
        oldY = camY;

        gameObject.transform.rotation = Quaternion.Euler(rotX * 180, rotY * 180, 0f) * gameObject.transform.rotation;
        */

        //Vector3 moveTo = gameObject.transform.rotation;
        /* RaycastHit hitInfo;

         bool hit = Physics.Raycast(Camera.main.transform.position,
                                 Camera.main.transform.forward,
                                 out hitInfo,
                                 20f,
                                 SpatialMappingManager.Instance.LayerMask);

         if (hit)
         {
             //moveTo = hitInfo.point + (offsetDistance * hitInfo.normal);
             float camX = hitInfo.point.x;
             float camY = hitInfo.point.y;

             float rotY = camX - oldX;
             float rotX = camY - oldY;

             oldX = camX;
             oldY = camY;

             gameObject.transform.rotation = Quaternion.Euler(rotX * 180, rotY * 180, 0f) * gameObject.transform.rotation;



         }
         else
         {
             // The raycast failed to hit a surface.  In this case, keep the object at the distance of the last
             // intersected surface.
            // moveTo = Camera.main.transform.position + (Camera.main.transform.forward * lastDistance);
             gameObject.transform.rotation = gameObject.transform.rotation;
         }*/
    }
}





