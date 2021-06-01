using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestionTrigger : MonoBehaviour
{
    public UnityEvent Event;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            Time.timeScale = 0.5F;
            Event.Invoke();
        }
    }
}
