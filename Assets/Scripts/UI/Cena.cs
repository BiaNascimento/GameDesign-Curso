using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Cena : MonoBehaviour {

    public Text Display;
    public string[] frases;
    private int index;
    public float digitar;
    public int proxCena;

    public GameObject continueBotao;

	// Use this for initialization
	void Start () {

        StartCoroutine(Type());
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Display.text == frases[index]) {
            continueBotao.SetActive(true);
        }

        if (index >= frases.Length) {

            Pular();

        }

       
	}

    IEnumerator Type()
    {

        foreach (char letter in frases[index].ToCharArray()) {

            Display.text += letter;
            yield return new WaitForSeconds(digitar);
                }

    }

    public void proxFrase() {
        continueBotao.SetActive(false);
        if (index < frases.Length - 1)
        {

            index++;
            Display.text = "";
            StartCoroutine(Type());
        }
        else {

            Display.text = "";
            continueBotao.SetActive(false);

        }
    }

    public void Pular() {

        SceneManager.LoadScene(proxCena);
        Debug.Log("Clicou");
    }
}
