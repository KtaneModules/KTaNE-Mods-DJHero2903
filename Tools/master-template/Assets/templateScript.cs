using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;

public class templateScript : MonoBehaviour
{
	public KMAudio Audio;
	public KMBombModule BombModule;
	public KMBombInfo Info;
	
	//public KMSelectable Button;


	//Logging
	static int moduleIdCounter = 1;
	int moduleId;

	bool Solved = false;

	void  Awake()
	{
		moduleId = moduleIdCounter++;
		//Button.OnInteract += delegate () { Button_Pressed(); return false; };

	}

 void Activate()
    {
        
        
    }
}
