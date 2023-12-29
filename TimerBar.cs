using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerBar : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMaxTime(int Time)
    {
        slider.maxValue = Time;
        slider.value = Time;
    }

    public void SetTime(int Time)
    {
        slider.value = Time;
    }


}
