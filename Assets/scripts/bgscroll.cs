using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgscroll : MonoBehaviour
{
    Material material;
    Vector2 offset;

    public float xvel, yvel;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = new Vector2(xvel, yvel);
    }

    void Update()
    {
        material.mainTextureOffset += offset * Time.deltaTime;
    }
}
