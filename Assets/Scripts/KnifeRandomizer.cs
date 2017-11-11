using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeRandomizer : MonoBehaviour {
    [SerializeField]
    private GameObject[] AllKnifes;
    [SerializeField]
    private int index;
    public GameObject chosenKnife;
    [SerializeField]
    private int RestOfKnifes = 10;
    [SerializeField]
    private float percentageOfChangeKnifeGoesIn;
    [SerializeField]
    private GameObject KnifePrefab;
    private Vector3 KnifeSpawnPosition;

    [Header("Arrayinfo")]
    [SerializeField]
    private int NumberOfKnivesInHole = 0;
    
    

    void Awake()
    {
        
    }  

	void Start ()
    {
        AfterAllCardsAreChosen();
        //wat je moet doen is een nieuwe array aanmaken, met de hoeveelheid zwaartjes die erin zijn gegaan, 10 zwaard berekening maken. dan die aantal in een array stoppen waardoor je die kan enablen
        
    }
	
	
	void Update ()
    {
		
	}

    void AddNewChosenKnife()
    {
        chosenKnife = AllKnifes[Random.Range(0, AllKnifes.Length)];
        chosenKnife.gameObject.SetActive(true);
    }


    //doet berekening 10 keer (10 zwaardjes) en laat de "gellukige" random enabelen, moet nog in array worden gezet
    void AfterAllCardsAreChosen()
    {
        for (int i = 0; i < 10; i++)
        {
            if (Random.value < percentageOfChangeKnifeGoesIn)
            {
                AddNewChosenKnife();
                //Debug.Log("gelukt");
                RestOfKnifes -= 1;
                NumberOfKnivesInHole += 1;
            }
        }
       
        SpawnRestOfKnifes();
    }

    void SpawnRestOfKnifes()
    {
        for (int i = 0; i < RestOfKnifes; i++)
        {
            Instantiate(KnifePrefab,new Vector3(Random.Range(8.887f, 7.877f), 29.772f, Random.Range(19.97f, 21.05f)), Random.rotation);
            
            
        }
        
    }

}

