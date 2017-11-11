using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCoinSpawnScript : MonoBehaviour {
    [SerializeField]
    private int currentSpawnPosition;
    [SerializeField]
    private Vector3[] SpawnPositions;
    private float _startPlayerValue;
    private float _currentPlayerValue;
    private float _CoinValue;
    [SerializeField]
    private GameObject CoinPrefab;
    
    
	
	void Start ()
    {
        currentSpawnPosition = 0;
        _startPlayerValue = GameObject.Find("GameLeader").GetComponent<PlayerValue>().StartplayerValue;
        _CoinValue = GameObject.Find("GameLeader").GetComponent<PlayerValue>().CoinValue;
        SetBeginCoins();
    }
	
	
	void Update ()
    {
		
	}

    void SetBeginCoins()
    {
        for (int i = 0; i < _startPlayerValue/_CoinValue; i++)
        {
            Instantiate(CoinPrefab, SpawnPositions[Random.Range(0, 3)], Quaternion.identity);
            
        }
    }
}
