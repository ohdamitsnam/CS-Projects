using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Job : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	int damage;
	int hp;
	int attackrange;
	int moverange;
	string jobname;
	protected int rolldice(){
		return Random.Range (1, 6);
	}
	protected void attack(Job job1, Job job2){
		int roll = job1.rolldice ();
		int totdamage = job1.damage * roll;
		job2.hp = job2.hp - totdamage;
		Debug.Log ("HP: " + job2.hp);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
