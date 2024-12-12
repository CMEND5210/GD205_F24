using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    float milliSecondsCount;
    int minutesCount;

    public TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        milliSecondsCount += Time.deltaTime;
        milliSecondsCount = Mathf.Round(milliSecondsCount * 100f) / 100f;
        text.text = "0" + minutesCount + ":" + "0" + milliSecondsCount;

        if (milliSecondsCount >= 60f)
        {
            minutesCount++;
            milliSecondsCount = 0f;
        }

        if (milliSecondsCount >= 10f)
        {
            text.text = "0" + minutesCount + ":" + milliSecondsCount;
        }

        if (minutesCount >= 10f && milliSecondsCount >= 10f)
        {
            text.text = minutesCount + ":" + milliSecondsCount;
        }

        else if (minutesCount >= 10f && milliSecondsCount < 10f)
        {
            text.text = minutesCount + ":" + "0" + milliSecondsCount;
        }
    }
}
