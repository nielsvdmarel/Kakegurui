using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInHoleRandomizer : MonoBehaviour
{
    public int KnifeNumber;
    public int LifeOrDeath;
    public bool Life = false;
    public bool Death = false;
    private GameObject game;
    public Vector2 GiveThroughVector;
    private int currentx;
    private int currenty;
    private Vector2[] nodigevector2;

    void Start()
    {

    }


    void Update()
    {

    }

    void RandomLifeDeath()
    {
        if (Random.value < 0.5f)
        {
            this.transform.localScale = new Vector3(4.925919f, 4.925919f, 4.925918f);
            Debug.Log("Life on " + KnifeNumber);
            Life = true;
            LifeOrDeath = 1;
            // 1 is life


        }
        else {
            this.transform.localScale = new Vector3(4.925919f, 4.925919f, -4.925918f);
            Debug.Log("Death on " + KnifeNumber);
            Death = true;
            LifeOrDeath = 0;
            //0 is death
        }
    }

    void OnEnable()
    {
        RandomLifeDeath();
        transform.gameObject.tag = "KnifeActive";
        SendInfoToVectorArray();
    }

    void OnDisable()
    {
        transform.gameObject.tag = "KnifeActive";
        RemoveInfoToVectorArray();
    }

    void SendInfoToVectorArray()
    {
        GiveThroughVector = new Vector2(KnifeNumber, LifeOrDeath);
        //GameObject.Find("GameLeader").GetComponent<GameLeader>().list.Add(this.gameObject);
        GameObject.Find("GameLeader").GetComponent<GameLeader>().KnifeNumberAndValue.Add(GiveThroughVector);

    }

    void RemoveInfoToVectorArray()
    {
        //GameObject.Find("GameLeader").GetComponent<GameLeader>().list.Remove(this.gameObject);
        GameObject.Find("GameLeader").GetComponent<GameLeader>().KnifeNumberAndValue.Remove(GiveThroughVector);
    }


    //deze nu niet nodig, naar mijn mening rare maar nu zelfs nettere uitweg die nu niet nodig lijkt te zijn.
    /*
   public void NewBalanceDecider()
    {
      nodigevector2 = GameObject.Find("GameLeader").GetComponent<GameLeader>().InzetPerVakje;
        if (nodigevector2.Length < 0)
        {
            for (int i = 0; i < nodigevector2.Length; i++)
            {
                if (KnifeNumber == nodigevector2[currentx].x)
                {
                    if (Life)
                    {

                        Debug.Log(KnifeNumber + ("win"));
                        //win = InzetPerVakje[NeededInt2].y * -32;
                        //Debug.Log(InzetPerVakje[NeededInt2].x + (" ") + win);
                    }
                    if (Death)
                    {
                        Debug.Log(KnifeNumber + ("Death"));
                        //loss = InzetPerVakje[NeededInt2].y * 32;
                        //Debug.Log(InzetPerVakje[NeededInt2].x + (" ") + loss);
                    }
                }
                else
                {
                    currentx++;
                }
            }

        }
        
    }
    */

}

    
       
