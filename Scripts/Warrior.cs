using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrior : Job
{
    int hp = 200;
    int attkrange = 1;
    int damage = 5;
    string jobname = "warrior";
    Text text;

    bool defbuff = false;
    // Use this for initialization
    void Start()
    {
        //Debug.Log("Dice roll: " + rolldice ());
        Job warrior1 = new Warrior();
        Job warrior2 = new Warrior();
        attack(warrior1, warrior2);
    }
    void buff()
    {
        defbuff = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}