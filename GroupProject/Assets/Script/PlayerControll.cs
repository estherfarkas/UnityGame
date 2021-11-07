using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    [SerializeField] float horizontalInput;
    [SerializeField] float verticalInput;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed = 5;

    [SerializeField] float xRange = 14;
    [SerializeField] float yRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(horizontalInput * speed, rigid.velocity.y);
        rigid.velocity = new Vector2(rigid.velocity.x,verticalInput*speed);

        //limit player movement in range between xRange and yRange
        rigid.position = new Vector2
        (
            Mathf.Clamp(rigid.position.x,-xRange,xRange),
            Mathf.Clamp(rigid.position.y,-yRange,yRange)
        );
        
    }

    
   
   
}
