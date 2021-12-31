using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f;

    void Start()
    {
        Destroy(gameObject, 1.0f);
    }

    void Update()
    {
        //방향 구하기
        Vector3 dir = Vector3.up;

        //이동: P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }


}
