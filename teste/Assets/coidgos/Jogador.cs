using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{

    // Start is called before the first frame update
        private Rigidbody2D rb;
        public int velocidade = 5;
        public bool noChao;
        public int forcaPulo = 7;
        
        private void OnCollisionEnter(Collision collision){
            if (!noChao && collision.gameObject.tag == "chão" ){
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
        float x = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        Vector2 direcao = new Vector2(x, v);
        rb.velocity = direcao.normalized * velocidade;
        if(Input.GetKeyDown(KeyCode.Space) && noChao){

            

            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Force);
            noChao = false;

        }
    }
}
