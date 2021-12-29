using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test00 : MonoBehaviour
{
    public int age = 24;
    public float height1 = 156.8f;
    public string pname = "강수연";
    public int answer;

    void Start()
    {
        //assignment 01
        Debug.Log("### 01. Hello World ###");
        Debug.Log("Hello, World!");

        //assignment 02
        Debug.Log("### 02. 변수 선언 ###");
        Debug.Log("age = " + age);

        //assignment 03
        Debug.Log("### 03. 변수 대입 ###");
        float height2;  height2 = height1;
        Debug.Log("height2 = "+height2);

        //assignment 04
        Debug.Log("### 04. 문자열 대입 ###");
        Debug.Log("name = " + pname);

        //assignment 05
        Debug.Log("### 05. 덧셈 결과 대입 ###");
        answer = 1 + 2; 
        Debug.Log("answer_plus = "+answer);

        //assignment 06
        Debug.Log("### 06. 사칙연산 ###");
        answer = 3 - 4; Debug.Log("answer_minus = "+answer);
        answer = 5 * 6; Debug.Log("answer_mul = " + answer);
        answer = 8 / 4; Debug.Log("answer_div = " + answer);

        //assignment 07
        Debug.Log("### 07. 변수 & 변수 연산 ###");
        int n1 = 8; int n2 = 9; answer = n1 + n2; 
        Debug.Log("n1 + n2 = " + answer);

        //assignment 08
        Debug.Log("### 08. 변수 값 증가 ###");
        answer = 10; answer += 5; 
        Debug.Log("answer = "+answer);

        //assignment 09
        Debug.Log("### 09. 변수 값 1 증가 ###");
        answer = 10; answer++; 
        Debug.Log("answer = " + answer);

        //assignment 10
        Debug.Log("### 10. 문자열 연결 1 ###");
        string st1 = "12월"; string st2 = "28일"; string message = st1 + st2;
        Debug.Log("message = " + message);


        //assignment 11
        Debug.Log("### 11. 문자열 연결 2 ###");
        st1 += st2; Debug.Log("st1 = " + st1);


        //assignment 12
        Debug.Log("### 12. 문자열 & 숫자 연결 ###");
        st1 = "오늘은 "; int date = 1228;  message = st1 + date;
        Debug.Log("message = " + message);

    }


}
