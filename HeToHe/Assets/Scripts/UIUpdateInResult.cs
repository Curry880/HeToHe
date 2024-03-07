using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdateInResult : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI corecteText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI resultText;
    void Start()
    {
        corecteText.text = GameManager.correctNum + "問正解";
        timerText.text = "クリアタイム：" + GameManager.finishTime;
        if (GameManager.correctNum < 4)
        {
            resultText.text = "しっかり観察して見よう！\n違いがわかってくるはず！";
        }
        else if (GameManager.correctNum < 7)
        {
            resultText.text = "めげずにもう一度挑戦してみよう！";
        }
        else if (GameManager.correctNum < 10)
        {
            resultText.text = "おしい！\nここまで来たら全問正解にチャレンジ！";
        }
        else if (GameManager.correctNum == 10)
        {
            resultText.text = "すごい！\nこれであなたはプロ「ヘ」ッショナルです！";
        }
    }
}
