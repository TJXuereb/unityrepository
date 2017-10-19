using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreakTextGame : MonoBehaviour {

	public Text myText;

	private enum States
	{
		cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, freedom, corridor_0, stairs_0, floor, closet_door,
        stairs_1, corridor_1, in_closet, corridor_2, stairs_2, corridor_3, courtyard

	};

	private States myState;

	// Use this for initialization
	void Start () {

		myState = States.cell;
		
	}

	void Cell () {
		myText.text = "“You are in a prison cell, and you want to escape." +
			"There are some dirty sheets on the bed, a mirror on the wall, and the door " +
			"is locked from the outside.\n\n" +
			"Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
	}

    void Sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's " +
            "time somebody changed them. The pleasures of prison life " +
            "I guess!\n\n" + "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void mirror_0()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
            "some dirty sheets on the bed, a mirror , " +
            "and that pesky door is still there, and firmly locked!\n\n" +
            "Press R to go back Cell or T to Take the Mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
    }

    void lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
            "combination is. You wish you could somehow see where the dirty " +
            "fingerprints were, maybe that would help.\n\n" +
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void cell_mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
            "some dirty sheets on the bed, a mark where the mirror was, " +
            "and that pesky door is still there, and firmly locked!\n\n" +
            "Press S to view Sheets, or L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        }
    }
    void sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
            "any better.\n\n" +
            "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }

    }
    void lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
            "so you can see the lock. You can just make out fingerprints around " +
            "the buttons. You press the dirty buttons, and hear a click.\n\n" +
            "Press O to Open, or R to Return to your cell";

        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    void freedom()
    {
        myText.text = "YOU ARE FREE!!" +
            "Now run for it!!" +
            "Press C to continue.";

        if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.corridor_0;
        }
    }
    void corridor_0()
    {
        myText.text = "Stairs, Floor or Closet door" +
            "Where to go?" +
            "Press S for Stairs, F for Floor or C for Closet Door";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.floor;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myState = States.closet_door;
        }
    }
    void stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n" +
            "Press R to return to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }

    }
    void closet_door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
            "Maybe you could find something around to help encourage it open?\n\n" +
            "Press R to return to the corridor";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" +
            "Press H to pick up the hairclip or R to return";

        if (Input.GetKeyDown(KeyCode.H))
        {
            myState = States.corridor_1;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    void corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
            "Now what? You wonder if that lock on the closet would succumb to " +
            "to some lock-picking?\n\n" +
            "Press S to try the stairs anyway or P to pick the closet door";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_1;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.in_closet;
        }
    }
    void stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
            "confidence to walk out into a courtyard surrounded by armed guards!\n\n" +
            "Press R to return to the corridor... again";
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }

    }
    void in_closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
            "Seems like your day is looking-up.\n\n" +
            "Press D to dress up or R to return";

        if (Input.GetKeyDown(KeyCode.D))
        {
            myState = States.corridor_3;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_1;
        }
    }
    void corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner." +
            "You strongly consider the run for freedom.\n\n" +
            "Press S to go up the stairs to the courtyard or U to undress... for some reason";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.courtyard;
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            myState = States.in_closet;
        }
    }
    void courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
            "The guard tips his hat at you as you waltz past, claiming " +
            "your freedom. You heart races as you walk into the sunset.\n\n" +
            "Press P to Play again.";

        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }


    // Update is called once per frame
    void Update () {

		print (myState);

		if (myState == States.cell) {
			Cell ();
		}
        else if (myState == States.sheets_0)
        {
            Sheets_0();
        }
        else if (myState == States.mirror)
        {
            mirror_0();
        }
        else if (myState == States.lock_0)
        {
            lock_0();
        }
        else if (myState == States.cell_mirror)
        {
            cell_mirror();
        }
        else if (myState == States.sheets_1)
        {
            sheets_1();
        }
        else if (myState == States.lock_1)
        {
            lock_1();
        }
        else if (myState == States.freedom)
        {
            freedom();
        }
        else if (myState == States.corridor_0)
        {
            corridor_0();
        }
        else if (myState == States.stairs_0)
        {
            stairs_0();
        }
        else if (myState == States.closet_door)
        {
            closet_door();
        }
        else if (myState == States.floor)
        {
            floor();
        }
        else if (myState == States.corridor_1)
        {
            corridor_1();
        }
        else if (myState == States.stairs_1)
        {
            stairs_1();
        }
        else if (myState == States.in_closet)
        {
            in_closet();
        }
        else if (myState == States.corridor_3)
        {
            corridor_3();
        }
        else if (myState == States.courtyard)
        {
            courtyard();
        }
	}
}
