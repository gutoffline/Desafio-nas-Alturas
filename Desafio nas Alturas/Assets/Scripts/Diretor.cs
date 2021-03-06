﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public GameObject imagemGameOver;
    [SerializeField]
    private Aviao aviao;
    private Pontuacao pontuacao;
<<<<<<< HEAD
=======

>>>>>>> 329c98b72cca46323a0890162a64b10a94caa3f7
    public void FinalizarJogo(){
        Time.timeScale = 0;
        imagemGameOver.SetActive(true);
        Debug.Log("Acabou");
    }

    void Start()
    {
        aviao = GameObject.FindObjectOfType<Aviao>();    
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    public void ReiniciarJogo(){
        aviao.Reiniciar();
        imagemGameOver.SetActive(false);
        Time.timeScale = 1;
        pontuacao.Reiniciar();
        DestruirObstaculos();
        Debug.Log("Reiniciou");
    }

    private void DestruirObstaculos(){
        Obstaculos[] obstaculosEncontrados = GameObject.FindObjectsOfType<Obstaculos>();
        foreach(Obstaculos obstaculoAtual in obstaculosEncontrados)
        {
            obstaculoAtual.Destruir();
        }
    }
}
