﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cachorro : MonoBehaviour
{
    public Transform DetectaChao;
    public float distancia;
    public bool olhandoParaDireita;
    public float velocidade;

    void Start()
    {
        olhandoParaDireita = true;
    }

    void Update()
    {
        Patrulha();
    }

    public void Patrulha()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(DetectaChao.position, Vector2.down, distancia);
        if (groundInfo.collider == false)
        {
            if (olhandoParaDireita == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                olhandoParaDireita = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = true;
            }
        }
    }
}