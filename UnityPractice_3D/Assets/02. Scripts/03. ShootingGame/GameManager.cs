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

    //게임의 종료 여부를 저장할 프로퍼티
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

    //싱글턴 인스턴스 선언
    public static GameManager instance = null;

    void Start()
    {
        //instance가 할당되지 않았을 경우
        if (instance == null)
        {
            instance = this;
        }
        //instance에 할당된 클래스의 인스턴스가 다를 경우 새로 생성된 클래스를 의미함
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
        //다른 씬으로 넘어가도 삭제하지 않고 유지함
        DontDestroyOnLoad(this.gameObject);


    }

    IEnumerator GameOver()
    {
        
        float fadeCount = 0; //처음 알파값
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
