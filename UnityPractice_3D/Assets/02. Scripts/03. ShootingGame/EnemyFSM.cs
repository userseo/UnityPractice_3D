using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public float speed = 5.0f;

    //플레이어 =  target으로 설정
    public GameObject target;
    Vector3 dir;

    public GameObject explisionPrefab;

    void Start()
    {

        //### 확률에 의한 분기처리 ###
        //Random Class 이용, 0~9의 랜덤 수를 가져와 3보다 작으면 Player방향, 아니면 아래방향
        int randValue = UnityEngine.Random.Range(0, 10);

        //방향 설정
        
        if (randValue < 3)
        {
            //target - mine
            dir = target.transform.position - transform.position;

            //방향의 크기 = 1;
            dir.Normalize();
            
        }
        else 
        {
            dir = Vector3.down;
        }

    }

    void Update()
    {
        //이동: P = P0 + vt
        transform.position += speed * Time.deltaTime * dir;

    }

    private void OnCollisionEnter(Collision other)
    {
        //폭발 효과 생성
        GameObject explostion = Instantiate(explisionPrefab, transform.position, Quaternion.identity);

        //부딪힌 오브젝트 파괴
        Destroy(other.gameObject);

        //이 게임 오브젝트 파괴
        Destroy(gameObject);
    }
}
