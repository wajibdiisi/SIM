using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class IntEvent : UnityEvent<int> {

}

public class Question : MonoBehaviour
{
    public UnityEvent destroyEvent;
    public ParticleSystem correctParticle;
    public ParticleSystem wrongParticle;
    public IntEvent scoreEvent;
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
    public void CheckAnswer(string answer){
        Transform child = transform.Find(answer);
        if(answer == correct_answer){
        destroyEvent.Invoke();
        scoreEvent.Invoke(100);
        correctParticle = Instantiate(correctParticle,child.position,child.rotation);
        correctParticle.gameObject.SetActive(true);
        Destroy(this.gameObject);
        }else{
        destroyEvent.Invoke();
        scoreEvent.Invoke(-100);
        wrongParticle = Instantiate(wrongParticle,child.position,child.rotation);
        wrongParticle.gameObject.SetActive(true);
        Destroy(this.gameObject);
        }   

    }
    public void ParticleCollision(string value){
        
    }
}
