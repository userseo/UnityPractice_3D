using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00 : MonoBehaviour
{
    public int age = 24;
    public float height1 = 156.8f;
    public string pname = "������";
    public int answer;

    void Start()
    {
        //assignment 01
        Debug.Log("### 01. Hello World ###");
        Debug.Log("Hello, World!");

        //assignment 02
        Debug.Log("### 02. ���� ���� ###");
        Debug.Log("age = " + age);

        //assignment 03
        Debug.Log("### 03. ���� ���� ###");
        float height2;  height2 = height1;
        Debug.Log("height2 = "+height2);

        //assignment 04
        Debug.Log("### 04. ���ڿ� ���� ###");
        Debug.Log("name = " + pname);

        //assignment 05
        Debug.Log("### 05. ���� ��� ���� ###");
        answer = 1 + 2; 
        Debug.Log("answer_plus = "+answer);

        //assignment 06
        Debug.Log("### 06. ��Ģ���� ###");
        answer = 3 - 4; Debug.Log("answer_minus = "+answer);
        answer = 5 * 6; Debug.Log("answer_mul = " + answer);
        answer = 8 / 4; Debug.Log("answer_div = " + answer);

        //assignment 07
        Debug.Log("### 07. ���� & ���� ���� ###");
        int n1 = 8; int n2 = 9; answer = n1 + n2; 
        Debug.Log("n1 + n2 = " + answer);

        //assignment 08
        Debug.Log("### 08. ���� �� ���� ###");
        answer = 10; answer += 5; 
        Debug.Log("answer = "+answer);

        //assignment 09
        Debug.Log("### 09. ���� �� 1 ���� ###");
        answer = 10; answer++; 
        Debug.Log("answer = " + answer);

        //assignment 10
        Debug.Log("### 10. ���ڿ� ���� 1 ###");
        string st1 = "12��"; string st2 = "28��"; string message = st1 + st2;
        Debug.Log("message = " + message);


        //assignment 11
        Debug.Log("### 11. ���ڿ� ���� 2 ###");
        st1 += st2; Debug.Log("st1 = " + st1);


        //assignment 12
        Debug.Log("### 12. ���ڿ� & ���� ���� ###");
        st1 = "������ "; int date = 1228;  message = st1 + date;
        Debug.Log("message = " + message);

    }


}
