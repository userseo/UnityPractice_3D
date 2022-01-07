using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject bullet;

    AudioSource aSource;
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //입력값 받기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //방향 설정
        Vector3 dir = new Vector3(h, v, 0);

        /*
         * 물리법칙: P = P0 + vt, v = v0 + at, F = ma 
         * P는 이동할 위치, P0는 현재 위치, v는 속도, t는 시간
         * F는 힘, m은 질량, a는 가속도
         */

        //translate을 사용한 이동: transform.Translate(dir * speed * Time.deltaTime);
        //P = P0 + vt 공식을 이용하여 위치를 계속 바꿔주는 식
        transform.position += dir * speed * Time.deltaTime;


        //추가: 마우스 왼쪽 버튼 누르면 총알을 발사
        if (Input.GetMouseButtonDown(0)) Fire();
    }

    void Fire()
    {
        aSource.Play();
        Vector3 firePos = transform.position;
        firePos.y += 0.5f;
        Instantiate(bullet, firePos, Quaternion.identity);



    }

    private void OnDisable()
    {
        GameManager.instance.IsGameOver = true;
    }
}
