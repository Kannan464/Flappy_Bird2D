using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float Height;
    public float Width;
    public float Offset;

    // Start is called before the first frame update
    void Start()
    {
        Height = Camera.main.orthographicSize * 2f;
        Width = Height * Screen.width / Screen.height;
        transform.localScale = new Vector3(Width, Height,.5f);
    }

    // Update is called once per frame
    void Update()
    {
        Offset += Time.deltaTime * 0.1f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(Offset, 0);
    }
}
