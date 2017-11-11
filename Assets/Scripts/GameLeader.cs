using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLeader : MonoBehaviour {
    [Header("full aantal coins die je nog hebt")]
    public int BettedCoins;
    [Header("Aantal coins die je nu inlegt")]
    public int newBettedCoinsafterfirstAcept;
    //bewaard voor formule
    private bool BettedCoinsAccept = false;
    public GameObject testobject;
    //
    [Header("Kaart nummer dat nu geselecteerd is")]
    public int selectedRedCard;
    [Header("systeem bijhouden nummer en aantal muntjes")]
    [SerializeField]
    public Vector2[] InzetPerVakje;
    //dit kan mooier niels
    [Header("Canvas")]
    [SerializeField]
    private GameObject canvasGroup1;
    [SerializeField]
    private GameObject canvasGroup2;
    [Header("Coins Spawner")]
    public Vector3 spawnpositonAtRedCard;
    
    [Header("Prefabs")]
    [SerializeField]
    private GameObject Coin;
    //dit is voor array index
    private int redcardcount;
    private GameObject _instance;
    public bool HasAcceptedForThisTurn;

    [Header("KnifeCount")]
    public List<Vector2> KnifeNumberAndValue = new List<Vector2>();
    private int NeededInt = 0;
    private int NeededInt2 = 0;
    [SerializeField]
    private float loss;
    [SerializeField]
    private float win;





    void Awake()
    {
       
        
    }

    void Start ()
    {
        redcardcount = 0;
        HasAcceptedForThisTurn = false;
        //CalculateNewValue();
    }
	
	void Update ()
    {
        if (BettedCoinsAccept)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ChosenNewCard();
                
                
            }   
        }
    }

    //set aantal muntjes die worden gebruikt
    void Stage1()
    {
        // niet de beste manier niels!
        canvasGroup1.SetActive(false);
        Debug.Log("verander array length naar aantal muntjes");
        InzetPerVakje = new Vector2[BettedCoins];
        newBettedCoinsafterfirstAcept = 0;
        canvasGroup2.SetActive(true);

    }

    void Stage2()
    {
        Debug.Log("Kies plekken en zet muntjes, moet nog doen dat je 10 seconden hebt");
        
    }

    //beginmuntjes hoeveelheid plus 1
    public void Up()
    {
        BettedCoins += 1;
    }
    
    //beginmuntjes hoeveelheid down 1
    public void Down()
    {
        BettedCoins -= 1;
    }

    //jou keuze van aantal muntjes
    public void Accept()
    {
       BettedCoinsAccept = true;
        Stage1();
    }

    public void Up2()
    {
        if(newBettedCoinsafterfirstAcept < BettedCoins)
        {
            HasAcceptedForThisTurn = false;
            newBettedCoinsafterfirstAcept += 1;
           _instance = Instantiate(Coin,testobject.transform.position, Quaternion.identity);
            
            
        }
        
    }

    public void Down2()
    {
        if (newBettedCoinsafterfirstAcept > 0)
        {
            
            newBettedCoinsafterfirstAcept -= 1;
            //CoinList.Remove(_instance);
            
            
            


        }
    }

    public void AcceptForThisRedCard()
    {
        if (newBettedCoinsafterfirstAcept > 0)
        {
            
            InzetPerVakje[redcardcount].y = newBettedCoinsafterfirstAcept;
            redcardcount += 1;
            HasAcceptedForThisTurn = true;
            BettedCoins -= newBettedCoinsafterfirstAcept;
            newBettedCoinsafterfirstAcept = 0;
            
        }
        
    }


    public void ChosenNewCard()
    {
        testobject = GameObject.Find("Main Camera").GetComponent<NumberSelection>().SelectedRedCard;
        
        selectedRedCard = System.Array.IndexOf(GameObject.Find("Main Camera").GetComponent<NumberSelection>().RedCards, testobject) + 1;
        InzetPerVakje[redcardcount].x = selectedRedCard;
        

    }

    public void SetCoinsOnBoard()
    {
        if (selectedRedCard > 0)
        {
           
        }
    }
    
    public void CalculateNewValue()
    {
        NeededInt = 0;
        if (KnifeNumberAndValue.Count > 0)
        {
            foreach (var item in KnifeNumberAndValue)
            {

                for (int i = 0; i < InzetPerVakje.Length; i++)
                {
                    {

                        if (KnifeNumberAndValue[NeededInt].x == InzetPerVakje[NeededInt2].x)
                        {


                            if (KnifeNumberAndValue[NeededInt].y == 1)
                            {
                                win = InzetPerVakje[NeededInt2].y * -32;
                                Debug.Log(InzetPerVakje[NeededInt2].x + (" ") + win);
                            }
                            if (KnifeNumberAndValue[NeededInt].y == 0)
                            {
                                loss = InzetPerVakje[NeededInt2].y * 32;
                                Debug.Log(InzetPerVakje[NeededInt2].x + (" ") + loss);
                            }

                            Debug.Log("nielsiscool");
                            NeededInt2 = 0;
                            NeededInt++;
                           
                        }
                        else
                        {
                            NeededInt2++;

                        }
                    }
                }
            }
        }
        else
        {
            Debug.Log("You are lukcy this round in any way");
            NewRound();
        }
    }
    
    public void NewRound()
    {

    }

    
}

