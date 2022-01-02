using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public float speed = 5.0f;

    //�÷��̾� =  target���� ����
    public GameObject target;
    Vector3 dir;

    void Start()
    {

        //### Ȯ���� ���� �б�ó�� ###
        //Random Class �̿�, 0~9�� ���� ���� ������ 3���� ������ Player����, �ƴϸ� �Ʒ�����
        int randValue = UnityEngine.Random.Range(0, 10);

        //���� ����
        
        if (randValue < 3)
        {
            //target - mine
            dir = target.transform.position - transform.position;

            //������ ũ�� = 1;
            dir.Normalize();
            
        }
        else 
        {
            dir = Vector3.down;
        }

        //������ Ŭ���� �����ϱ� ���� 3�ʰ� ������ ����
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
        //�̵�: P = P0 + vt
        transform.position += speed * Time.deltaTime * dir;

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("BULLET"))
        {
            //�ε��� ������Ʈ �ı�
            Destroy(other.gameObject);

            //�� ���� ������Ʈ �ı�
            Destroy(gameObject);
        }
        else if(other.gameObject.CompareTag("PLAYER"))
        {
            //�� ���� ������Ʈ �ı�
            Destroy(gameObject);
        }

    }
}
