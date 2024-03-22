using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    
    private Rigidbody2D rb;
    
    
    private Animator anie;

    public int fp = 1000;

    public bool nochao;
    private void OnCollisionEnter2D(Collision2D collision){
        if (!nochao && collision.gameObject.tag == "Chão" ){
            nochao = true;
            anie.SetBool("nochao" , true);
        }
        else
        {
            anie.SetBool("no ar", true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * Speed;
            anie.SetBool("Andando" , true);
            transform.eulerAngles = new Vector2(0f, 0f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * Speed;
            anie.SetBool("Andando", true);
            transform.eulerAngles = new Vector2(0f, 180f);
        }
        else
        {
            anie.SetBool("Andando", false);
        }

        
        if (Input.GetKeyDown(KeyCode.Space) && nochao)
        {
            rb.AddForce(transform.up * fp, ForceMode2D.Impulse);
            
            anie.SetBool("pulando", true);
            nochao = false;
            anie.SetBool("nochao" , false);
        }
        else
        {
            anie.SetBool("pulando", false);
        }
    }
}
