using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Foods : MonoBehaviour
{
    private GameManager gameManager;
    public AudioSource audio;
<<<<<<< Updated upstream
    public int nutritionValue;
    [SerializeField] GameObject[] rottenFoodPrefab;
=======
    [SerializeField] public int nutritionValue;

    [SerializeField] public int perishablilityTimer;

    [SerializeField] public float timer;
    
    [SerializeField] GameObject rottenFoodPrefab;
>>>>>>> Stashed changes

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
             
<<<<<<< Updated upstream
        yield return new WaitForSeconds(10); //timer
=======
        yield return new WaitForSeconds(perishablilityTimer); //timer
>>>>>>> Stashed changes

        if(this.gameObject != GameObject.FindGameObjectWithTag("RottenFood"))
        {
        Destroy(this.gameObject);
        Instantiate(rottenFoodPrefab[0], gameObject.transform.position,Quaternion.identity);
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
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
        Destroy(gameObject);
        gameManager.UpdateNutritionPoint(nutritionValue);
<<<<<<< Updated upstream
=======
        gameManager.timeRemaining += timer;

        }
>>>>>>> Stashed changes
    }




}
