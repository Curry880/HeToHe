using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameManager : MonoBehaviour
{
    private List<int> questions = new List<int>();
    private int question;
    private int currentCount;

    [SerializeField]
    private Text quizText;
    [SerializeField]
    private Text resultText;
    [SerializeField]
    private Text TimerText;
    [SerializeField]
    private Text CurrentText;
    [SerializeField]
    private Text TotalText;

    [SerializeField]
    private SEManager seManager;
    SceneController sceneController = new SceneController();

    private Coroutine hideCoroutine;

    void Start()
    {
        for(int i=0; i < GameManager.numOfQuestions; i++)
        {
            //0ならひらがな、1ならカタカナ
            int answer = Random.Range(0, 2);
            questions.Add(answer);
        }
        currentCount = 0;
        question = questions[0];
        TotalText.text = GameManager.numOfQuestions.ToString();
        resultText.text = "";

        GameManager.numOfCorrects = 0;
        GameManager.Timer = 0;

        UpdateQuiz();
        UpdateCurrent();
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Timer += Time.deltaTime;
        TimerText.text = GameManager.Timer.ToString("F2");
    }

    private void NextQuestion()
    {
        currentCount++;
        if (currentCount >= GameManager.numOfQuestions)
        {
            // 一秒待つ
            sceneController.ToResult();
            return;
        }
        question = questions[currentCount];
        UpdateCurrent();
        UpdateQuiz();
    }

    private void UpdateQuiz()
    {
        switch (GameManager.currentLevel)
        {
            case Level.Esey:
                break;
            case Level.Normal:
                quizText.fontSize = Random.Range(72, 200);
                break;
            case Level.Hard:
                quizText.fontSize = Random.Range(72, 200);
                quizText.transform.Rotate(0, 0, Random.Range(-90, 90));
                break;
        }

        if (question == 0)
        {
            quizText.text = "へ";
        }
        else
        {
            quizText.text = "ヘ";
        }
    }

    private void UpdateCurrent()
    {
        CurrentText.text = (currentCount + 1).ToString();
    }

    public void OnClickedHira()
    {
        if(question == 0)
        {
            seManager.PlayCorrectSE();  
            resultText.text = "正解";
            GameManager.numOfCorrects++;
        }
        else
        {
            seManager.PlayWrongSE();
            resultText.text = "不正解";
        }
        if (hideCoroutine != null)
        {
            StopCoroutine(hideCoroutine);
        }
        hideCoroutine = StartCoroutine(HideText());
        NextQuestion();
    }

    public void OnClickedKata()
    {
        if (question == 0)
        {
            seManager.PlayWrongSE();
            resultText.text = "不正解";
        }
        else
        {
            seManager.PlayCorrectSE();
            resultText.text = "正解";
            GameManager.numOfCorrects++;
        }
        if (hideCoroutine != null)
        {
            StopCoroutine(hideCoroutine);
        }
        hideCoroutine = StartCoroutine(HideText());
        NextQuestion();
    }

    private IEnumerator HideText()
    {
        yield return new WaitForSeconds(1.0f);
        resultText.text = "";
        hideCoroutine = null;
    }
}
