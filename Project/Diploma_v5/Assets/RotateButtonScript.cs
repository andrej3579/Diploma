
using System.Collections;
using UnityEngine;
namespace Academy.HoloToolkit.Unity
{
    public class RotateButtonScript : MonoBehaviour
    {
        public void OnSelect()
        {
            GameObject menu = this.transform.parent.gameObject;
            GameObject light = menu.transform.parent.gameObject;
            GameObject head = light.transform.GetChild(0).gameObject;
            Component[] list = head.GetComponents(typeof(Component));

            //RotateLight rotate = gameObject.GetComponent<RotateLight>();


        }
    }
}
