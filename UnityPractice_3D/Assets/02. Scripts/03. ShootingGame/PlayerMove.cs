using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject bullet;

    void Start()
    {
    }

    void Update()
    {
        //�Է°� �ޱ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //���� ����
        Vector3 dir = new Vector3(h, v, 0);

        /*
         * ������Ģ: P = P0 + vt, v = v0 + at, F = ma 
         * P�� �̵��� ��ġ, P0�� ���� ��ġ, v�� �ӵ�, t�� �ð�
         * F�� ��, m�� ����, a�� ���ӵ�
         */

        //translate�� ����� �̵�: transform.Translate(dir * speed * Time.deltaTime);
        //P = P0 + vt ������ �̿��Ͽ� ��ġ�� ��� �ٲ��ִ� ��
        transform.position += dir * speed * Time.deltaTime;


        //�߰�: ���콺 ���� ��ư ������ �Ѿ��� �߻�
        if (Input.GetMouseButtonDown(0)) Fire();
    }

    void Fire()
    {
        Vector3 firePos = transform.position;
        firePos.y += 0.5f;
        Instantiate(bullet, firePos, Quaternion.identity);



    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ENEMY"))
        {

            GameManager.instance.IsGameOver = true;
            Destroy(gameObject);
        }
    }
}
