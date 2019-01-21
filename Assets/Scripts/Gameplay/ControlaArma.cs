using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{

    public ReservaExtensivel reservaDeBalas;
    public GameObject CanoDaArma;
    public AudioClip SomDoTiro;

    private void Update()
    {

#if UNITY_EDITOR
        if (Input.GetButtonDown("Fire1")) {
            this.Atirar();
        }

#else
        var toquesNaTela = Input.touches;
        foreach(var toque in toquesNaTela)
        {
            if(toque.phase == TouchPhase.Began)
            {
                this.Atirar();
                ControlaAudio.instancia.PlayOneShot(SomDoTiro);
            }
        }
#endif
    }

    private void Atirar()
    {
        if (this.reservaDeBalas.TemObjeto())
        {
            var bala = this.reservaDeBalas.PegarObjeto();
            bala.transform.position = CanoDaArma.transform.position;
            bala.transform.rotation = CanoDaArma.transform.rotation;
        }
    }
}
