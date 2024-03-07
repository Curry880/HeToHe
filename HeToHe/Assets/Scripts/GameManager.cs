using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int[] ansQuiz = new int[10];
    int ans;
    public int currentquiz;
    public static int correctNum;
    float startTime;
    public float timer;
    public static float finishTime;
    bool ansered;
    bool finish;
    [SerializeField] SceneChanger sceneChanger;
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            //0ならひらがな、1ならカタカナ
            ansQuiz[i] = Random.Range(0, 2);
        }
        //0ならひらがな、1ならカタカナ、2なら未選択
        ans = 2;
        currentquiz = 1;
        correctNum = 0;
        startTime = Time.time;
        finishTime = 0;
        ansered = false;
        finish = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish == true) return;
        timer = Time.time - startTime;

        if (ans == 2) return;
        if (ansered == false) return;

        if(ans == ansQuiz[currentquiz-1])
        {
            ResultEffect(true);
            correctNum++;
        }
        else
        {
            ResultEffect(false);
        }
        currentquiz++;
        ans = 2;
        ansered = false;

        if(currentquiz == 11)
        {
            finishTime = timer;
            finish = true;
            sceneChanger.ToResult();
        }
    }

    void ResultEffect(bool correct)
    {
        if(correct == true)
        {
            
        }
        else
        {

        }
    }

    public void AnsHira()
    {
        ans = 0;
        ansered = true;
    }

    public void AnsKata()
    {
        ans = 1;
        ansered = true;
    }
}
