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
        Debug.Log("### 01. if�� ��� ###");
        if (herbNum == 1) {
            hp += 50;
            Debug.Log("ü���� 50 ȸ��");
        }


        //assignment 02
        Debug.Log("### 02. if ~else�� ��� 1 ###");
        if (hp >= 100) Debug.Log("����!"); else Debug.Log("���!");

        //assignment 03
        Debug.Log("### 03. if ~else�� ��� 2 ###");
        if (hp <= 50) Debug.Log("����");
        else if (hp >= 200) Debug.Log("����!");   else Debug.Log("���!");

        //assignment 04: if�� ��Ͽ��� ������ ������ ����� �� �ִ� ������ ������ �ִ�.
        Debug.Log("### 04. ���� ���� ###");
        int x = 1;
        if (x == 1){
            int y = 2;
            Debug.Log("x = " + x + ", y = " + y);
        }
        //Debug.Log("y = "+y); //if�� �ȿ��� �����߱� ������ ������ ��!

        //assignment 05
        Debug.Log("### 05. for�� ��� ###");
        for (int i = 0; i < 5; i++) Debug.Log("i = "+i);

        //assignment 06
        Debug.Log("### 06. ¦���� ��� ###");
        for (int i = 0; i < 10; i += 2) Debug.Log("i = " + i);

        //assignment 07
        Debug.Log("### 07. Ư�� ������ ���  ###");
        for (int i = 3; i <= 5; i++) Debug.Log("i = " + i);

        

        //assignment 09
        Debug.Log("### 09. �հ� ���ϱ� ###");
        int sum = 0;
        for (int i = 1; i <= 10; i++) sum += i;
        Debug.Log("1~10�� �հ� = " + sum);

        //assignment 10
        Debug.Log("### 10. �迭 ��� ###");
        array[0] = 2; array[1] = 10; array[2] = 5; array[3] = 15; array[4] = 3;
        for (int i = 0; i < 5; i++) Debug.Log("array�� "+i+"��° ��� = "+array[i]);

        //assignment 11
        Debug.Log("### 11. ������ �����ϴ� ��Ҹ� ��� ###");
        for (int i = 0; i < points.Length; i++) 
            if (points[i] >= 90) Debug.Log("points�� "+i+"��° ��� = "+points[i]);

        //assignment 12
        Debug.Log("### 12. ��հ� ���ϱ� ###");
        sum = 0;
        for (int i = 0; i < points.Length; i++) sum += points[i];
        int average = sum / points.Length;  
        Debug.Log("points�� ��� = " + average);

        //assignment 08
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {
        Debug.Log("### 08. ī��Ʈ �ٿ� ###");
        for (int i = 3; i >= 0; i--)
        {
            yield return new WaitForSeconds(1);
            Debug.Log(i+"��...");
        }
        Debug.Log("ī��Ʈ �ٿ� ��!");
       
    }
}
