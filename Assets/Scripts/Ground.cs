using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    public Transform camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(camera.position.x - 5.5f >= transform.position.x)
        {
            transform.position = new Vector2(transform.position.x + 11, 0);
        }
    }
}
