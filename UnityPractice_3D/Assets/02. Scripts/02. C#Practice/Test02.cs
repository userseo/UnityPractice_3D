using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "데미지를 입혔다.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다.");
    }
}

public class Test02 : MonoBehaviour
{
    void Start()
    {
        //assignment 01
        Debug.Log("### 01. Hello 출력 메서드 ###");
        SayHello();

        //assignment 02
        Debug.Log("### 02. 인수 출력 메서드 ###");
        CallName("Ashe");

        //assignment 03
        Debug.Log("### 03. 값 2개의 합계를 반환하는 메서드 ###");
        Debug.Log("두 값의 합 = "+Add(2, 3));


        //assignment 04
        Debug.Log("### 04. 플레이어 클래스 ###");
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);


        //assignment 05
        Debug.Log("### 05. Vector2 클래스 멤버 변수에 숫자 더하기 ###");
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f; playerPos.y += 5.0f;
        Debug.Log("2D 플레이어의 위치 = "+playerPos);

        //assignment 06
        Debug.Log("### 06. Vector2 사이의 뺄셈 ###");
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;    
        Debug.Log("이동 방향 벡터값 = "+dir);

        Debug.Log("이동 거리 = " + dir.magnitude);

    }

    void SayHello()
    {
        Debug.Log("Hello");
    }

    void CallName(string name)
    {
        Debug.Log("Hello, " + name+"!");
    }

    int Add(int a, int b)
    {
        return a + b;
    }

    void Update()
    {
        
    }
}
