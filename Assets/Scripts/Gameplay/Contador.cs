using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Contador : MonoBehaviour {

    public Text contador;
    public float tempo, tempoLimite;
    public GameObject vitoria;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tempo = Time.timeSinceLevelLoad;
        contador.text = tempo.ToString("F1");
        if (tempo  >= tempoLimite)
        {
            Debug.Log("funfou");
            proximaFase();
        }
    }

    void proximaFase() {

        SceneManager.LoadScene(3);
        

    }
}
