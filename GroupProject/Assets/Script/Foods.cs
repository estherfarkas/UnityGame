using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Foods : MonoBehaviour
{
    private GameManager gameManager;
    public AudioSource audio;
    public int nutritionValue;

    public int perishablilityTimer;

    public int timeValue;
    
    [SerializeField] GameObject rottenFoodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(PerishablilityTimer());

        if (audio == null){
             audio = GetComponent<AudioSource>();}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator PerishablilityTimer()
    {

        //replace a rotten food after X second
        while(true)
        {
             
        yield return new WaitForSeconds(perishablilityTimer); //timer

        if(this.gameObject == GameObject.FindGameObjectWithTag("Food"))
        {
        Destroy(this.gameObject);
        Instantiate(rottenFoodPrefab, gameObject.transform.position,Quaternion.identity);
        
        gameManager.UpdateWasteCounter();

        }


        }


    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {

        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        Destroy(gameObject);
        gameManager.UpdateNutritionPoint(nutritionValue);
        gameManager.timeRemaining += timeValue;
        }
    }




}
