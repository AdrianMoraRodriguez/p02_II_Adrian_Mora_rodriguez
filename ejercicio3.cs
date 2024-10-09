using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio3 : MonoBehaviour
{
  public Vector3 vector1;
  public Vector3 vector2;
    // Start is called before the first frame update
    void Start() {
      Debug.Log("Magnitud de vector 1: " + vector1.magnitude);
      Debug.Log("Magnitud de vector 2: " + vector2.magnitude);

      float angle = Vector3.Angle(vector1, vector2);
      Debug.Log("Ángulo entre vector 1 y vector 2: " + angle + " grados");

      float distance = Vector3.Distance(vector1, vector2);
      Debug.Log("Distancia entre vector 1 y vector 2: " + distance);

      if (vector1.y > vector2.y) {
        Debug.Log("vector 1 está a una altura mayor que vector 2.");
      } else if (vector1.y < vector2.y) {
        Debug.Log("vector 2 está a una altura mayor que vector 1.");
      } else {
        Debug.Log("Ambos vectores están a la misma altura.");
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
