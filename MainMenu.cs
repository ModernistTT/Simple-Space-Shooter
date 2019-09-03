﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
  
  public void PlayGame ()
  {
	  SceneManager.LoadScene("Game1");
	  
  }  

  public void Quit ()
  {
	  Application.Quit();
  }  

}
