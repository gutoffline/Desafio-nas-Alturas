﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.2f;
    [SerializeField]
    private float variacaoDaPosicaoY;

    private void Awake() {
        transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }
    void Update()
    {
        transform.Translate(Vector3.left * velocidade);
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        Destruir();
    }
    public void Destruir(){
        GameObject.Destroy(this.gameObject);
        Debug.Log("Colidiu");
    }
}
