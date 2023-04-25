using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePipe : MonoBehaviour
{
    public GameObject Pipe;
    public Vector2 pos;
   
 
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GeneratePipes());
    }

    // Update is called once per frame
    
    IEnumerator GeneratePipes()
    {
        
            while (true)
            {
                yield return new WaitForSeconds(2f);
                float Object = Random.Range(1f, -3f);
                pos = new Vector2(transform.position.x, Object);
            GameObject Pipe = ObjectPooling.sharedinstance.GetPooledObject();
            Pipe.SetActive(true);
            Pipe.transform.position = pos;
                //Instantiate(Pipe,pos, Quaternion.identity);

            }
            
           
    }
   
}

