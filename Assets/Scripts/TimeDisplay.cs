using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText; // Inspector���� �Ҵ��� Text ������Ʈ

    void Update()
    {
        DateTime now = DateTime.Now;
        timeText.text = now.ToString("HH:mm:ss"); // �ð� ������ "��:��:��"�� ����
    }
}