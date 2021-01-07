using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using KModkit;

public class ColouredButtonsScript : MonoBehaviour
{
	public KMAudio Audio;
	public KMBombModule BombModule;
	public KMBombInfo Info;
	public KMSelectable Red_Button;
	public KMSelectable Orange_Button;
	public KMSelectable Yellow_Button;
	public KMSelectable Green_Button;
	public KMSelectable Blue_Button;
	public KMSelectable Cyan_Button;
	public KMSelectable Purple_Button;
	public KMSelectable Magenta_Button;
	public KMSelectable Brown_Button;
	public KMSelectable Tan_Button;
	public KMSelectable Grey_Button;
	public KMSelectable Black_Button;

	//Logging
	static int moduleIdCounter = 1;
	int moduleId;

	string Solution = "";
 	bool foundSolution = false;

	string SolutionColour = "";

	bool Solved = false;

	void  Awake()
	{
		moduleId = moduleIdCounter++;
		Red_Button.OnInteract += delegate () { PressedRed(); return false; };
		Orange_Button.OnInteract += delegate () { PressedOrange(); return false; };
		Yellow_Button.OnInteract += delegate () { PressedYellow(); return false; };
		Green_Button.OnInteract += delegate () { PressedGreen(); return false; };
		Blue_Button.OnInteract += delegate () { PressedBlue(); return false; };
		Cyan_Button.OnInteract += delegate () { PressedCyan(); return false; };
		Purple_Button.OnInteract += delegate () { PressedPurple(); return false; };
		Magenta_Button.OnInteract += delegate () { PressedMagenta(); return false; };
		Brown_Button.OnInteract += delegate () { PressedBrown(); return false; };
		Tan_Button.OnInteract += delegate () { PressedTan(); return false; };
		Grey_Button.OnInteract += delegate () { PressedGrey(); return false; };
		Black_Button.OnInteract += delegate () { PressedBlack(); return false; };
	}

 void Activate()
    {
        
        
    }

// Twitch Plays Support.
		public string TwitchHelpMessage = "Press a button with !{0} <Colour>, // Valid Colours are: Red, Orange, Yellow, Green, Blue, Cyan, Purple, Magenta, Brown, Tan, Grey, Black.";
		public KMSelectable[] ProcessTwitchCommand(string command)
		{
			if (command.Equals("Red", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Red_Button };
			}
			else if (command.Equals("Orange", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Orange_Button };
			}

			else if (command.Equals("Yellow", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Yellow_Button };
			}

			else if (command.Equals("Green", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Green_Button };
			}

			else if (command.Equals("Blue", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Blue_Button };
			}

			else if (command.Equals("Cyan", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Cyan_Button };
			}

			else if (command.Equals("Purple", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Purple_Button };
			}

			else if (command.Equals("Magenta", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Magenta_Button };
			}

			else if (command.Equals("Brown", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Brown_Button };
			}

			else if (command.Equals("Tan", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Tan_Button };
			}

			else if (command.Equals("Grey", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Grey_Button };
			}
			
			else if (command.Equals("Black", StringComparison.InvariantCultureIgnoreCase))
			{
				return new KMSelectable[] { Black_Button };
			}

			return null;
		}

	void Start ()
	 {

		if (((Info.IsIndicatorPresent(Indicator.SND) && foundSolution != true)))
		{
			Solution = "SND";
			foundSolution = true;
			SolutionColour = "Red";
		}

		if (((Info.IsIndicatorPresent(Indicator.CLR) && foundSolution != true)))
		{
			Solution = "CLR";
			foundSolution = true;
			SolutionColour = "Orange";
		}

		if (((Info.IsIndicatorPresent(Indicator.CAR) && foundSolution != true)))
		{
			Solution = "CAR";
			foundSolution = true;
			SolutionColour = "Yellow";
		}

		if (((Info.IsIndicatorPresent(Indicator.IND) && foundSolution != true)))
		{
			Solution = "IND";
			foundSolution = true;
			SolutionColour = "Green";
		}

		if (((Info.IsIndicatorPresent(Indicator.FRQ) && foundSolution != true)))
		{
			Solution = "FRQ";
			foundSolution = true;
			SolutionColour = "Blue";
		}

		if (((Info.IsIndicatorPresent(Indicator.SIG) && foundSolution != true)))
		{
			Solution = "SIG";
			foundSolution = true;
			SolutionColour = "Cyan";
		}

		if (((Info.IsIndicatorPresent(Indicator.NSA) && foundSolution != true)))
		{
			Solution = "NSA";
			foundSolution = true;
			SolutionColour = "Purple";
		}

		if (((Info.IsIndicatorPresent(Indicator.MSA) && foundSolution != true)))
		{
			Solution = "MSA";
			foundSolution = true;
			SolutionColour = "Magenta";
		}

		if (((Info.IsIndicatorPresent(Indicator.TRN) && foundSolution != true)))
		{
			Solution = "TRN";
			foundSolution = true;
			SolutionColour = "Brown";
		}

		if (((Info.IsIndicatorPresent(Indicator.BOB) && foundSolution != true)))
		{
			Solution = "BOB";
			foundSolution = true;
			SolutionColour = "Tan";
		}

		if (((Info.IsIndicatorPresent(Indicator.FRK) && foundSolution != true)))
		{
			Solution = "FRK";
			foundSolution = true;
			SolutionColour = "Grey";
		}

		if (foundSolution != true)
		{ 
			Solution = "No Indicators";
			foundSolution = true;
			SolutionColour = "Black";
		}
		
	}



		void PressedRed()
		{
			
			if (Solution == "SND" && Solved == false)
			{
			Red_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Red_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Red Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Red_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Red_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Red Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedOrange()
		{
			
			if (Solution == "CLR" && Solved == false)
			{
			Orange_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Orange_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Orange Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Orange_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Orange_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Orange Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedYellow()
		{
			
			if (Solution == "CAR" && Solved == false)
			{
			Yellow_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Yellow_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Yellow Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Yellow_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Yellow_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Yellow Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedGreen()
		{
			
			if (Solution == "IND" && Solved == false)
			{
			Green_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Green_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Green Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();	
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;
			}
			
			else
			{
			
				if (Solved == false)
				{
				Green_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Green_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Green Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedBlue()
		{
			
			if (Solution == "FRQ" && Solved == false)
			{
			Blue_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Blue_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Blue Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);	
			Solved = true;
			}
			
			else
			{
			
				if (Solved == false)
				{
				Blue_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Blue_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Blue Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedCyan()
		{
			
			if (Solution == "SIG" && Solved == false)
			{
			Cyan_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Cyan_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Cyan Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);	
			Solved = true;
			}
			
			else
			{
			
				if (Solved == false)
				{
				Cyan_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Cyan_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Cyan Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedPurple()
		{
			
			if (Solution == "NSA" && Solved == false)
			{
			Purple_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Purple_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Purple Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);	
			Solved = true;
			}
			
			else
			{
			
				if (Solved == false)
				{
				Purple_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Purple_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Purple Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedMagenta()
		{
			
			if (Solution == "MSA" && Solved == false)
			{
			Magenta_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Magenta_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Magenta Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Magenta_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Magenta_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Magenta Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedBrown()
		{
			
			if (Solution == "TRN" && Solved == false)
			{
			Brown_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Brown_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Brown Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Brown_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Brown_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Brown Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedTan()
		{
			
			if (Solution == "BOB" && Solved == false)
			{
			Tan_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Tan_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Tan Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Tan_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Tan_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Tan Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedGrey()
		{
			
			if (Solution == "FRK" && Solved == false)
			{
			Grey_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Grey_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Grey Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Grey_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Grey_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Grey Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

		void PressedBlack()
		{
			
			if (Solution == "No Indicators" && Solved == false)
			{
			Black_Button.AddInteractionPunch();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Black_Button.transform);
			Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Black Button, The Correct Answer Is: "+ SolutionColour +", Solved!", moduleId);
			GetComponent<KMBombModule>().HandlePass();
			Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.CorrectChime, transform);
			Solved = true;	
			}
			
			else
			{
			
				if (Solved == false)
				{
				Black_Button.AddInteractionPunch();
				Audio.PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, Black_Button.transform);
				Debug.LogFormat("[Coloured Button Pad #{0}] You Pressed The Black Button, The Correct Answer Is: "+ SolutionColour +", Strike!", moduleId);
				GetComponent<KMBombModule>().HandleStrike();
				}

			}
		}

}