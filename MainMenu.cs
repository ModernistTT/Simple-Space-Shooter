using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
  //This script needs more context than anything, so heres what happenens in unity.
  //Step 1: Create Main Menu Texture
  //Step 2: Create button to play game (Unity has a built in button to just drag & drop)
  //Step 3: Create button to quit game
  //Step 4: Assign this script to the main menu
  public void PlayGame ()
  {
          //This script does not recieve input from pressing the button, but recieves input from another script and then takes the input and uses it to load the game
	  SceneManager.LoadScene("Game1");
	  
  }  

  public void Quit ()
  {
          //Terminates the application
	  Application.Quit();
  }  

}
