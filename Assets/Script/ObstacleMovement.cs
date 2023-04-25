using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float speed;
         void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <-14)  
        {
            transform.position = new Vector2(50, 0);
            gameObject.SetActive(false);
           }
    }
}
