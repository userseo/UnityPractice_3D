using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //硅版 material
    public Material bgMaterial;

    //胶农费 加档
    public float scrollSpeed = 0.2f;

    void Start()
    {
        
    }

    void Update()
    {
        //胶农费: P = P0 + vt
        bgMaterial.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
