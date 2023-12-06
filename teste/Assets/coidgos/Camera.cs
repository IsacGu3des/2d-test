using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform alvo;
    // Start is called before the first frame update
    void Start()
    {
        alvo = GameObject.FindWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = alvo.position - transform.forward;
    }
    
}
