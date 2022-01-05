using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "�������� ������.");
    }

    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }
}

public class Test02 : MonoBehaviour
{
    void Start()
    {
        //assignment 01
        Debug.Log("### 01. Hello ��� �޼��� ###");
        SayHello();

        //assignment 02
        Debug.Log("### 02. �μ� ��� �޼��� ###");
        CallName("Ashe");

        //assignment 03
        Debug.Log("### 03. �� 2���� �հ踦 ��ȯ�ϴ� �޼��� ###");
        Debug.Log("�� ���� �� = "+Add(2, 3));


        //assignment 04
        Debug.Log("### 04. �÷��̾� Ŭ���� ###");
        Player myPlayer = new Player();
        myPlayer.Attack();
        myPlayer.Damage(30);


        //assignment 05
        Debug.Log("### 05. Vector2 Ŭ���� ��� ������ ���� ���ϱ� ###");
        Vector2 playerPos = new Vector2(3.0f, 4.0f);
        playerPos.x += 8.0f; playerPos.y += 5.0f;
        Debug.Log("2D �÷��̾��� ��ġ = "+playerPos);

        //assignment 06
        Debug.Log("### 06. Vector2 ������ ���� ###");
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - startPos;    
        Debug.Log("�̵� ���� ���Ͱ� = "+dir);

        Debug.Log("�̵� �Ÿ� = " + dir.magnitude);

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
