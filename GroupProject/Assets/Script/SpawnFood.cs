using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public float spawnPosX;
    public float spawnPosY;
    [SerializeField] GameObject foodPrefab;


    


    // Start is called before the first frame update
    void Start()
    {
        //spawn one food at the beginning
        Instantiate (foodPrefab, SpawnPosition(), Quaternion.identity);

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
        yield return new WaitForSeconds(5); //timer

        Instantiate (foodPrefab, SpawnPosition(), Quaternion.identity);
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
