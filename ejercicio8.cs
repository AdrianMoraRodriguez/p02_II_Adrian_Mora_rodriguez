using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio8 : MonoBehaviour
{
    int maxDistanceIndex = 0;
    GameObject[] type_2_spheres;
    void Start() {
      type_2_spheres = GameObject.FindGameObjectsWithTag("Sphere_T2");
      GameObject cube = GameObject.Find("Cube");
      int minDistanceIndex = 0;
      float minDistance = Vector3.Distance(type_2_spheres[0].transform.position, cube.transform.position);
      float maxDistance = Vector3.Distance(type_2_spheres[0].transform.position, cube.transform.position);
      for (int i = 0; i < type_2_spheres.Length; i++) {
        if (Vector3.Distance(type_2_spheres[i].transform.position, cube.transform.position) < minDistance) {
            minDistance = Vector3.Distance(type_2_spheres[i].transform.position, cube.transform.position);
            minDistanceIndex = i;
        }
        if (Vector3.Distance(type_2_spheres[i].transform.position, cube.transform.position) > maxDistance) {
            maxDistance = Vector3.Distance(type_2_spheres[i].transform.position, cube.transform.position);
            maxDistanceIndex = i;
        }
      }
        type_2_spheres[minDistanceIndex].GetComponent<Transform>().position = type_2_spheres[minDistanceIndex].GetComponent<Transform>().position + new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update() {
      if (Input.GetKeyDown(KeyCode.Space)) {
        type_2_spheres[maxDistanceIndex].GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
      }
    }
}
