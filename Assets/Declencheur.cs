using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Declencheur : MonoBehaviour
{
    public int nbcube;
    // Start is called before the first frame update
    void Start()
    {
        nbcube = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //On touche la zone, le compteur s'incrémente et on affiche dans la console le nombre de cube(s) qui ont été déposés
    nbcube++;
    Debug.Log("Cube(s) : "+nbcube);
    }
}
