using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{

    // Start is called before the first frame update
        private Rigidbody2D rb;
        public int velocidade = 5;
        public bool noChao;
        public int forcaPulo = 7;
        
        private void OnCollisionEnter2D(Collision2D collision){
            if (!noChao && collision.gameObject.tag == "Chão" ){
                noChao = true;
            }
        }
        
    void Start()
    {
        TryGetComponent(out rb);
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        if(transform.position.y <= -5 ){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        Vector2 direcao = new Vector2(x, 0);
        rb.velocity = direcao * velocidade;
        if(Input.GetKeyDown(KeyCode.Space) && noChao){

            

            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Force);
            noChao = false;
            

        }
    }
}
