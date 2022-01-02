using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //랜덤 시간
    float minTime = 1.0f;  float maxTime = 5.0f;
    public float createTime;
    public float currentTime = 0;

    //적 Prefab
    public GameObject enemyPrefab;

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    void Update()
    {
        //시간을 흐르게
        currentTime += Time.deltaTime;

        //일정 시간이 되면 적을 생성
        if (currentTime > createTime)
        {
            CreateEnemy();
        }
    }

    public void CreateEnemy()
    {
        //적 복제
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        
        //시간 초기화
        currentTime = 0;

        //적 생성 시간 재설정
        createTime = UnityEngine.Random.Range(minTime, maxTime);

    }
}
