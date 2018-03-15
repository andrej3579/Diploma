using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;
using UnityEngine.VR.WSA.Input;

public class WorldScript : MonoBehaviour {

    /*
    public float RotationSensitivity = 10.0f;

    GameObject targetObject = null;
    GestureRecognizer gr = null;

    // Use this for initialization
    void Start()
    {
        SetupGestureRecognizer();
        //MoveTarget(0f);
    }


    void Update()
    {
        RotateTarget(GetMouseInputX(), GetMouseInputY());
    }

    void SetupGestureRecognizer()
    {
        gr = new GestureRecognizer();
        gr.NavigationUpdatedEvent += NavigationUpdatedEvent;
        gr.StartCapturingGestures();
    }

    float GetMouseInputX()
    {
        return Camera.main.ScreenToViewportPoint(Input.mousePosition).x;
    }

    float GetMouseInputY()
    {
        return Camera.main.ScreenToViewportPoint(Input.mousePosition).y;
    }

    void NavigationUpdatedEvent(InteractionSourceKind source, Vector3 normalizedOffset, Ray headRay)
    {
        float x = normalizedOffset.x * 0.5f + 0.5f;
        float y = normalizedOffset.y * 0.5f + 0.5f;
        RotateTarget(x * RotationSensitivity, y * RotationSensitivity);
        MoveTarget(0);
    }

    // t must be a value between 0.0 and 1.0
    void MoveTarget(GameObject targetObject, float x)
    {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(x, 0, 5.0f));
        targetObject.transform.position = pos;
    }

    void RotateTarget(GameObject targetObject, float x, float y)
    {
        targetObject.transform.rotation = Quaternion.Euler(x * RotationSensitivity, y * RotationSensitivity, 0);
    }*/
}
