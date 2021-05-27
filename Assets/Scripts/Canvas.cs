using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Canvas : MonoBehaviour
{
    public bool doCountDown;
    float currentTime = 3f;
    public Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(doCountDown == true){
            currentTime -= 1 *  Time.deltaTime;
            countDownText.text = currentTime.ToString("0");
            if(currentTime <= 0 ){
                countDownText.enabled = false;
                doCountDown = false;
            }
        }
    }
    public void changeCountDown(bool value){
        this.doCountDown = value;
        this.currentTime = 3f;
        countDownText.enabled = true;
    }
}
