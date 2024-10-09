using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4 : MonoBehaviour
{
    void OnGUI() {
        GUI.Label(new Rect(20, 20, 100, 40),"" + transform.position);
    }
}
