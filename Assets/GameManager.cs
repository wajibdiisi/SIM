using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class GameManager : MonoBehaviour
{
    public int currentScore;
    public TextMeshProUGUI scoreText;
    public int correctAnswer;
    public int wrongAnswer;
    public TextMeshProUGUI scoreTextFinish;
    public TextMeshProUGUI correctScore;
    public TextMeshProUGUI wrongScore;
    public TextMeshProUGUI finishText;
    public UnityEvent resultEvent;
    public GameObject pausePanel;
    public GameObject deathParticle;
    public GameObject character;
    ThirdPersonCamera thirdPersonCamera;
    CharacterController cc;
    public UnityEvent startTimer;
    bool crRunning;
    bool isPaused;
    bool isFinished;
    // Start is called before the first frame update
    void Start()
    {
        thirdPersonCamera = character.GetComponentInChildren<ThirdPersonCamera>();
        cc = character.GetComponent<CharacterController>();
        if(crRunning == false){
            StartCoroutine(startGame());
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }else{
                PauseGame();
            }
        }
        if(currentScore < -2000 && !isFinished ){
            isFinished = true;
            
            deathParticle.SetActive(true);
            showResult();

        }
    }
    public void PauseGame(){
        pausePanel.SetActive(true);
        thirdPersonCamera.enabled = false;
        isPaused = true;
        Time.timeScale = 0f;
    }

    public void ResumeGame(){
        pausePanel.SetActive(false);
        thirdPersonCamera.enabled = true;
        isPaused = false;
        Time.timeScale = 1f;
    }
    public void UpdateScore(int score){
        if(score == 100){
            correctAnswer += 1;
        }else if(score == -100){
            wrongAnswer += 1;
        }
        currentScore += score;
        scoreText.text = "Score : " + currentScore.ToString();
    }
    public void showResult(){
        Animator anim = character.GetComponent<Animator>();
        thirdPersonCamera.enabled = false;
           
           
        if(isFinished){
             cc.enabled = false;
             anim.SetTrigger("Death");
        finishText.text = "Mission Failed";
        }else {
               cc.enabled = false;
           finishText.text = "Mission Finished"; 
        }

        correctScore.text = "Correct : " + correctAnswer.ToString();
        scoreTextFinish.text = "Score : " + currentScore.ToString();
        wrongScore.text = "Wrong : " + wrongAnswer.ToString();
        resultEvent.Invoke();
        if(isFinished){
        StartCoroutine(waitFinish(2f));
        }else {
            StartCoroutine(waitFinish(1f));
        }

    }
    IEnumerator waitFinish(float time){
        yield return new WaitForSeconds(time);
        Time.timeScale = 0F;
    }
    public void Retry(){
        Scene scn = SceneManager.GetActiveScene();
        Debug.Log(scn);
        SceneManager.LoadScene(scn.name);

    }
    IEnumerator startGame(){
        crRunning = true;
        GetComponent<Canvas>().changeCountDown(5);
        cc.enabled = false;
        yield return new WaitForSeconds(5f);
        cc.enabled = true;
        crRunning = false;
    }
}
