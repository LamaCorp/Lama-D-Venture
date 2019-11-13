using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class NewBehaviourScript1 : MonoBehaviour {
  public int timeLeft = 60; 
  public Text countdown;
  private GameObject UI;
  public GameObject gameOver;
  
  void Start () {
    StartCoroutine("LoseTime");
    Time.timeScale = 1; 
    UI = GameObject.FindGameObjectWithTag("timeAmount");
  }
  void Update () {
    countdown.text = ("Temps restant :" + timeLeft);

    if (timeLeft <= 0){
      timeLeft = 0;
         Time.timeScale = 0;
      gameOver.SetActive(true);
    }
  }
  
  IEnumerator LoseTime()
  {
    while (true) {
      yield return new WaitForSeconds (1);
      timeLeft--; 
    }
  }
  }