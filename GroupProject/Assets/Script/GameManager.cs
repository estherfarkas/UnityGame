using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public Text nutritionText;
    public Text wasterCounterText;

    public Text timerText;

    private int nutritionPoint = 0;
    private int wasteCounter = 0;

    public float timeRemaining = 60;

    public GameObject pausePanel;

    // Start is called before the first frame update
    void Start()
    {
        UpdateNutritionPoint(0);
        
    }

    // Update is called once per frame
    void Update()
    {
         

        UpdateTime();
    }

   public void UpdateNutritionPoint(int pointToAdd)
    {
        nutritionPoint += pointToAdd;
        PersistantData.Instance.SetScore(nutritionPoint);
        nutritionText.text = "Nutrition Points: " + nutritionPoint;

        Debug.Log(nutritionPoint);
    }

    public void UpdateWasteCounter()
    {
        wasteCounter += 1;
        wasterCounterText.text = "Waste Food: " + wasteCounter;

    }

    public void Pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);

    }

    public void GameOver()
    {
        Time.timeScale = 0;
        Debug.Log("Game OVer");
    }

    public void UpdateTime()
    {
        
        timeRemaining =  Mathf.Clamp(timeRemaining, 0.0f,60.0f);

        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time left: " + seconds.ToString("00");
        }

        else
        {
            GameOver();
        }
    }

    
}
