using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroyer : MonoBehaviour {

    [SerializeField]
    private int SpawnValue;
    private int NeededValue;

    public bool setCoins;

	
	void Start ()
    {
        setCoins = false;
        SpawnValue = GameObject.Find("GameLeader").GetComponent<GameLeader>().newBettedCoinsafterfirstAcept;
	}
	
	
	void Update ()
    {
        if (setCoins == false)
        {
            if (GameObject.Find("GameLeader").GetComponent<GameLeader>().HasAcceptedForThisTurn == true)
            {
                SetCoins();
            }
        }
        if (setCoins == false)
        {
            if (SpawnValue > GameObject.Find("GameLeader").GetComponent<GameLeader>().newBettedCoinsafterfirstAcept)
            {
              Destroy(this.gameObject);
            }
        }
	}

    void Destroy()
    {
        Destroy(this.gameObject);
    }

    void SetCoins()
    {
        setCoins = true;
        Debug.Log("dontDestroy");
    }
}
