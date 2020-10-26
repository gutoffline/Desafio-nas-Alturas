using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int pontos;
<<<<<<< HEAD

    private AudioSource somPontuacao;
    private void Awake()
    {
        somPontuacao = this.GetComponent<AudioSource>();
    }
    public void AdicionarPontos()
    {
=======
    private AudioSource somPontuacao;

    void Awake()
    {
        somPontuacao = GetComponent<AudioSource>();        
    }
    public void AdicionarPontos(){
>>>>>>> 329c98b72cca46323a0890162a64b10a94caa3f7
        pontos += 1;
        somPontuacao.Play();
        AtualizarTexto();
    }

<<<<<<< HEAD
    private void AtualizarTexto()
    {
        textoPontuacao.text = this.pontos.ToString();
    }

    public void Reiniciar()
    {
        pontos = 0;
        AtualizarTexto();
    }
=======
    private void AtualizarTexto(){
        textoPontuacao.text = pontos.ToString();
    }

    public void Reiniciar(){
        pontos = 0;
        AtualizarTexto();
    }

>>>>>>> 329c98b72cca46323a0890162a64b10a94caa3f7
}
