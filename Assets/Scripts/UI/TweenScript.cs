using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CanvasGroup cg = this.GetComponent<CanvasGroup>();
        LeanTween.alphaCanvas(cg, 
    to: 1f, 
    time: 0.7f
).setFrom(0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
