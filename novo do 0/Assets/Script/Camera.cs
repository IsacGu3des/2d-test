using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform alvo;

    private Vector3 direcao;

    private float y;
    // Start is called before the first frame update
    void Start()
    {


        alvo = GameObject.FindWithTag("Player").transform;
        
        


    }

    // Update is called once per frame
    void Update()
    {
        
        direcao = new Vector3(0, y, -15);
        transform.position = alvo.position + direcao;
        


    }
    
}
