using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeDisplay : MonoBehaviour
{
    public Text timeText; // Inspector에서 할당할 Text 컴포넌트

    void Update()
    {
        DateTime now = DateTime.Now;
        timeText.text = now.ToString("HH:mm:ss"); // 시간 형식을 "시:분:초"로 설정
    }
}