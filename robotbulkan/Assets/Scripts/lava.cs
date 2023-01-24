using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava : MonoBehaviour
{
    private float lavaspeed= 0.006f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + lavaspeed, transform.position.z);
    }
}
