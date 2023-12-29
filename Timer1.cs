using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer1 : MonoBehaviour
{

    int time = 40;
    public TextMeshProUGUI timer_text;
    public target target_script;

    public GameObject winImg;
    public GameObject loseImg;

    public bool allEnemeiesDestroyed = false;

    public TimerBar TimeBar;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer_count", 1f, 1f);
        TimeBar.SetMaxTime(time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Timer_count()
    {
        time--;
        
        TimeBar.SetTime(time);
        if (allEnemeiesDestroyed == true)
        {
            winImg.SetActive(true);
        }
        
        if (time <= 0)
        {
            CancelInvoke();
            if (allEnemeiesDestroyed == false){
                loseImg.SetActive(true);

            }
        }
    }
}
