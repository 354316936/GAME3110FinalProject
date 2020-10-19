using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchGame : MonoBehaviour
{
    [SerializeField] private GameObject SearchTheGame = null;
    [SerializeField] private GameObject SearchingTheGame = null;

    

    public void SearchAGame()
    {
       
        SearchTheGame.SetActive(false);
        SearchingTheGame.SetActive(true);
    }

    public void CancelAGame()
    {
        SearchTheGame.SetActive(true);
        SearchingTheGame.SetActive(false);
    }


    // Start is called before the first frame update
    void Start()
    {
        SearchTheGame.SetActive(true);
        SearchingTheGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
