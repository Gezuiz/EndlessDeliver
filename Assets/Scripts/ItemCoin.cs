﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCoin : MonoBehaviour
{
    private AudioSource _audio;

    private void FixedUpdate()
    {
        this.transform.rotation = Quaternion.Euler(0, 50 * Time.time, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        MainManager.Instance.ContadorDeMoedas();
        // _audio.Play();
        Destroy(gameObject, .2f);
    }
}
