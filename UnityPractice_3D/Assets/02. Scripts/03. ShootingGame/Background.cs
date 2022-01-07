using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    //��� material
    public Material bgMaterial;

    //��ũ�� �ӵ�
    public float scrollSpeed = 0.2f;

    void Start()
    {
        
    }

    void Update()
    {
        //��ũ��: P = P0 + vt
        bgMaterial.mainTextureOffset += Vector2.up * scrollSpeed * Time.deltaTime;
    }
}
