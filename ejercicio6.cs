using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio6 : MonoBehaviour
{
  public Vector3 offsetSphere;
  public Vector3 offsetCube;
  public Vector3 offsetCylinder;
  GameObject cube;
  GameObject sphere;
  GameObject cylinder;
    // Start is called before the first frame update
    void Start() {
      cube = GameObject.Find("Cube");
      sphere = GameObject.Find("Sphere");
      cylinder = GameObject.Find("Cylinder");
    }

    // Update is called once per frame
    void Update() {
      if (Input.GetAxis("Jump") > 0) {
        cube.transform.position = cube.transform.position + offsetCube;
        sphere.transform.position = sphere.transform.position + offsetSphere;
        cylinder.transform.position = cylinder.transform.position + offsetCylinder;
      }
    }
}
