using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
      
    }

    // Update is called once per frame
    void Update() {
      if (Input.GetKeyDown(KeyCode.C)) {
        GameObject cylinder = GameObject.Find("Cylinder");
        cylinder.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
      } else if (Input.GetKeyDown(KeyCode.UpArrow)) {
        GameObject cube = GameObject.Find("Cube");
        cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
      }
    }
}
