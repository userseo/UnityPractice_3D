using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    public int herbNum = 1;
    public int hp = 200;
    int[] array = new int[5];
    int[] points = { 83, 99, 52, 93, 15};

    void Start()
    {
        //assignment 01
        Debug.Log("### 01. if문 사용 ###");
        if (herbNum == 1) {
            hp += 50;
            Debug.Log("체력을 50 회복");
        }


        //assignment 02
        Debug.Log("### 02. if ~else문 사용 1 ###");
        if (hp >= 100) Debug.Log("공격!"); else Debug.Log("방어!");

        //assignment 03
        Debug.Log("### 03. if ~else문 사용 2 ###");
        if (hp <= 50) Debug.Log("도망");
        else if (hp >= 200) Debug.Log("공격!");   else Debug.Log("방어!");

        //assignment 04: if문 블록에서 정의한 변수는 사용할 수 있는 범위가 정해져 있다.
        Debug.Log("### 04. 변수 범위 ###");
        int x = 1;
        if (x == 1){
            int y = 2;
            Debug.Log("x = " + x + ", y = " + y);
        }
        //Debug.Log("y = "+y); //if문 안에서 선언했기 때문에 오류가 남!

        //assignment 05
        Debug.Log("### 05. for문 사용 ###");
        for (int i = 0; i < 5; i++) Debug.Log("i = "+i);

        //assignment 06
        Debug.Log("### 06. 짝수만 출력 ###");
        for (int i = 0; i < 10; i += 2) Debug.Log("i = " + i);

        //assignment 07
        Debug.Log("### 07. 특정 범위만 출력  ###");
        for (int i = 3; i <= 5; i++) Debug.Log("i = " + i);

        

        //assignment 09
        Debug.Log("### 09. 합계 구하기 ###");
        int sum = 0;
        for (int i = 1; i <= 10; i++) sum += i;
        Debug.Log("1~10의 합계 = " + sum);

        //assignment 10
        Debug.Log("### 10. 배열 사용 ###");
        array[0] = 2; array[1] = 10; array[2] = 5; array[3] = 15; array[4] = 3;
        for (int i = 0; i < 5; i++) Debug.Log("array의 "+i+"번째 요소 = "+array[i]);

        //assignment 11
        Debug.Log("### 11. 조건을 만족하는 요소만 출력 ###");
        for (int i = 0; i < points.Length; i++) 
            if (points[i] >= 90) Debug.Log("points의 "+i+"번째 요소 = "+points[i]);

        //assignment 12
        Debug.Log("### 12. 평균값 구하기 ###");
        sum = 0;
        for (int i = 0; i < points.Length; i++) sum += points[i];
        int average = sum / points.Length;  
        Debug.Log("points의 평균 = " + average);

        //assignment 08
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        Debug.Log("### 08. 카운트 다운 ###");
        for (int i = 3; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(i+"초...");
        }
        Debug.Log("카운트 다운 끝!");
       
    }
}
