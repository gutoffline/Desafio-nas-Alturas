using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    
    Rigidbody2D fisica;
    [SerializeField]
    private float forca = 10f;

    [SerializeField]
    private Diretor diretor;
    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Impulsionar(){
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        fisica.simulated = false;
        diretor.FinalizarJogo();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Impulsionar();
        }
    }
}
