using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    public int frameDelay = 120;
    private Renderer rend;
    private int currentFrame = 0;
    private Color currentColor;
    // Start is called before the first frame update
    void Start() {
      rend = GetComponent<Renderer>();
      currentColor = new Color(Random.value, Random.value, Random.value);
      rend.material.color = currentColor;
    }

    // Update is called once per frame
    void Update() {
      currentFrame++;
      if (currentFrame >= frameDelay) {
        currentFrame = 0;
        currentColor = new Color(Random.value, Random.value, Random.value);
        rend.material.color = currentColor;
      }  
    }
}
