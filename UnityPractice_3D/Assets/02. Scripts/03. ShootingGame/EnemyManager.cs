using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //���� �ð�
    float minTime = 1.0f;  float maxTime = 5.0f;
    public float createTime;
    public float currentTime = 0;

    //�� Prefab
    public GameObject enemyPrefab;

    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    void Update()
    {
        //�ð��� �帣��
        currentTime += Time.deltaTime;

        //���� �ð��� �Ǹ� ���� ����
        if (currentTime > createTime)
        {
            CreateEnemy();
        }
    }

    public void CreateEnemy()
    {
        //�� ����
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        
        //�ð� �ʱ�ȭ
        currentTime = 0;

        //�� ���� �ð� �缳��
        createTime = UnityEngine.Random.Range(minTime, maxTime);

    }
}
