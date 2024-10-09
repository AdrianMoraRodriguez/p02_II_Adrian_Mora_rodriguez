using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
      GameObject sphere = GameObject.Find("Sphere");
      GameObject cube = GameObject.Find("Cube");
      GameObject cylinder = GameObject.Find("Cylinder");
      Debug.Log("Distancia entre la esfera y el cubo: " + Vector3.Distance(sphere.transform.position, cube.transform.position));
      Debug.Log("Distancia entre la esfera y el cilindro: " + Vector3.Distance(sphere.transform.position, cylinder.transform.position));
    }

    // Update is called once per frame
    void Update() {}
}
