using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerDamage : MonoBehaviour
{
    public IntEvent damageEvent;
     public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player")){
            damageEvent.Invoke(-200);
            particle =Instantiate(particle,transform.position,transform.rotation);
            particle.gameObject.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
