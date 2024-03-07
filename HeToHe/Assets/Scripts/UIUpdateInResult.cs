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
        corecteText.text = GameManager.correctNum + "�␳��";
        timerText.text = "�N���A�^�C���F" + GameManager.finishTime;
        if (GameManager.correctNum < 4)
        {
            resultText.text = "��������ώ@���Č��悤�I\n�Ⴂ���킩���Ă���͂��I";
        }
        else if (GameManager.correctNum < 7)
        {
            resultText.text = "�߂����ɂ�����x���킵�Ă݂悤�I";
        }
        else if (GameManager.correctNum < 10)
        {
            resultText.text = "�������I\n�����܂ŗ�����S�␳���Ƀ`�������W�I";
        }
        else if (GameManager.correctNum == 10)
        {
            resultText.text = "�������I\n����ł��Ȃ��̓v���u�w�v�b�V���i���ł��I";
        }
    }
}
