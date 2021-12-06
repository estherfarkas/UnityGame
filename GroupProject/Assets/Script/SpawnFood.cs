using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public float spawnPosX;
    public float spawnPosY;
    [SerializeField] GameObject [] foodPrefab;


    


    // Start is called before the first frame update
    void Start()
    {
        //spawn one food at the beginning
        Instantiate (foodPrefab[0], SpawnPosition(), Quaternion.identity);

        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //spawn a food every X second
    IEnumerator Spawn()
    {
        while(true)
        {
        yield return new WaitForSeconds(2); //timer
        int foodNumber = Random.Range(0, 3);
        Instantiate (foodPrefab[foodNumber], SpawnPosition(), Quaternion.identity);
        }
    }

    //generate random position
    Vector2 SpawnPosition()
    {
        spawnPosX = Random.Range(-10f,10f);
        spawnPosY = Random.Range(-5f,5f);

        Vector2 randomPosition = new Vector2 (spawnPosX,spawnPosY);

        return randomPosition;
    }
}
