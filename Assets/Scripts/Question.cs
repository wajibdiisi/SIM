using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Question : MonoBehaviour
{
    public UnityEvent destroyEvent;
    public string correct_answer;
    public string selected_answer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectedAnswer(string value){
        

    }
    public void CheckAnswer(string answer){
        if(answer == this.correct_answer ){
            Debug.Log("Benar");
        }else{
            Debug.Log("Salah");
            
        }
        destroyEvent.Invoke();
        Destroy(this.gameObject);
    }
}
