﻿
using System.Collections;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

namespace Academy.HoloToolkit.Unity
{
    public class RotateLight : Singleton<RotateLight>
    {
        [Tooltip("Rotation max speed controls amount of rotation.")]
        public float RotationSensitivity = 10.0f;
        private float rotationFactor;

        GameObject targetObject = null;
        GestureRecognizer gr = null;

        // Use this for initialization
        void Start()
        {
            SetupGestureRecognizer();
            MoveTarget(0f);
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
        void MoveTarget(float x)
        {
            Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(x, 0, 5.0f));
            targetObject.transform.position = pos;
        }

        void RotateTarget(float x, float y)
        {
            this.transform.rotation = Quaternion.Euler(x * RotationSensitivity, y * RotationSensitivity, 0);
        }
    }
}