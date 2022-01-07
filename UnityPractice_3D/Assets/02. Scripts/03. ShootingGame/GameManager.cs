using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] EnemyManagers;
    public GameObject Player;
    public Image overPanel;

    public bool isGameOver;

    //������ ���� ���θ� ������ ������Ƽ
    public bool IsGameOver
    {
        get { return isGameOver; }
        set
        {
            isGameOver = value;
            if (isGameOver)
            {
                StartCoroutine(SoundFadeout());

                foreach (GameObject enemyMan in EnemyManagers)
                {
                    enemyMan.SetActive(false);
                }

                StartCoroutine(GameOver());
            }
        }

    }

    //�̱��� �ν��Ͻ� ����
    public static GameManager instance = null;

    void Start()
    {
        //instance�� �Ҵ���� �ʾ��� ���
        if (instance == null)
        {
            instance = this;
        }
        //instance�� �Ҵ�� Ŭ������ �ν��Ͻ��� �ٸ� ��� ���� ������ Ŭ������ �ǹ���
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
        //�ٸ� ������ �Ѿ�� �������� �ʰ� ������
        DontDestroyOnLoad(this.gameObject);


    }

    IEnumerator GameOver()
    {
        
        float fadeCount = 0; //ó�� ���İ�
        overPanel.color = new Color(0, 0, 0, fadeCount);
        overPanel.gameObject.SetActive(true);

        while (fadeCount < 0.8f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            overPanel.color = new Color(0, 0, 0, fadeCount);
        }
    }

    IEnumerator SoundFadeout()
    {
        AudioSource bgAudio = GameObject.Find("Background").GetComponent<AudioSource>();

        for (float i = 0; i <= 1.0f; i += 0.01f)
        {
            bgAudio.volume -= i;
            yield return new WaitForSeconds(0.1f);
        } 
    }

    

}
