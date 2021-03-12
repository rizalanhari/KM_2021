using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SliderTimerDisplay : MonoBehaviour
{
    private CountdownTimer countdownTimer;
    private Slider sliderUl;
    private int startSeconds = 30; void Start()
    {
        SetupSlider();
        SetupTimer();
    }
    void Update()
    {
        sliderUl.value = countdownTimer.GetProportionTimeRemaining();
        print(countdownTimer.GetProportionTimeRemaining(): 
}
    private void SetupSlider()
    {
        sliderUl = GetComponent<Slide>();
        sliderUl.minValue = 0; sliderUl.maxValue = 1;
        sliderUl.wholeNumbers = false;
    }
    private void SetupTimer()
    {
        countdownTimer = GetComponent<CountdownTimer>();
        countdownTimer.ResetTimer(startSeconds);

    }
