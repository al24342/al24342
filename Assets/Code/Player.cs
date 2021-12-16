using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Public Variables
    public GameObject bullet;
    //Private Variable
Rigidbody2D r2d;
    // Start is called before the first frame update
    void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*  float horizontal = Input.GetAxis("Horizontal"); //Se detetar as setas direita/esquerda do teclado irá se mover
          float vertical = Input.GetAxis("Vertical"); //Se detetar as setas cima/baixo do teclado irá se mover

          float velocidadeX = (horizontal * this.velocidadeMovimento);
          float velocidadeY = (vertical * this.velocidadeMovimento);

          this.r2d.velocity = new Vector2(velocidadeX, velocidadeY);*/

        if (Input.GetKey("right"))
        {                                                            //se detetar a seta direita do teclado, a nave se moverá para a direita
            r2d.velocity = new Vector2(10, 0);
        }
        else if (Input.GetKey("left"))                      
        {                                                           //se detetar a seta esquerda do teclado, a nave se moverá para a esquerda
            r2d.velocity = new Vector2(-10, 0); 
        }
        else
        {
            r2d.velocity = new Vector2(0, 0); //se não detetar nenhuma das setas irá ficar no mesmo lugar
        }

        if (Input.GetKeyDown("space"))//Código para disparo, Botão espaço do teclado
        {
            Vector3 bulletSp = transform.position;
            bulletSp.y += 0.5f;

            Instantiate(bullet, bulletSp, Quaternion.identity);
        }
    }
}
