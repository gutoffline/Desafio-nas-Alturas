using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.2f;
    [SerializeField]
    private float variacaoDaPosicaoY;

    private Vector3 posicaoDoAviao;
    private Pontuacao pontuacao;
    private bool pontuei;
<<<<<<< HEAD
    private void Start()
    {
        posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
=======

    void Start()
    {
        posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();        
>>>>>>> 329c98b72cca46323a0890162a64b10a94caa3f7
    }

    private void Awake() {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }
    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
<<<<<<< HEAD


        if(!pontuei && transform.position.x < posicaoDoAviao.x)
        {
=======
        if(!pontuei && this.transform.position.x < posicaoDoAviao.x){
>>>>>>> 329c98b72cca46323a0890162a64b10a94caa3f7
            pontuei = true;
            pontuacao.AdicionarPontos();
        }
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        Destruir();
    }
    public void Destruir(){
        GameObject.Destroy(this.gameObject);
        Debug.Log("Colidiu");
    }
}
