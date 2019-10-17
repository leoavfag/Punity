using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rigi;
    private Transform playert; 

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        playert = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        movimentação();
    }
    private void movimentação(){
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        Vector2 posicao = new Vector2(Horizontal,Vertical);
        

        if(Horizontal>0){
            rigi.MovePosition(new Vector2((transform.position.x + posicao.x * velocidade * Time.deltaTime),
            (transform.position.y + posicao.y * velocidade * Time.deltaTime)));
            transform.eulerAngles = new Vector2(0,0);
        }
        if(Horizontal<0){
            rigi.MovePosition(new Vector2((transform.position.x + posicao.x * velocidade * Time.deltaTime),
            (transform.position.y + posicao.y * velocidade * Time.deltaTime)));
            transform.eulerAngles = new Vector2(0,180);
        }



    }

}
