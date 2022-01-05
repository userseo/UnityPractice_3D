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
        //���� ���ϱ�
        Vector3 dir = Vector3.up;

        //�̵�: P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }


}
