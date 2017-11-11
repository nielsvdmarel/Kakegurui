using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject knife;
    public Vector3 spawnposition;
    [SerializeField]
    private float SpawnTimer;
    public bool isspawning;

	// Use this for initialization
	void Start ()
    {
        isspawning = true;
        StartCoroutine(startIe());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   public IEnumerator startIe()
    {
       

        while (true)
        {
            Debug.Log("OnCoroutine: " + (int)Time.time);
            yield return new WaitForSeconds(SpawnTimer);
            Instantiate(knife, spawnposition, Quaternion.identity);
        }



    }
    
}
