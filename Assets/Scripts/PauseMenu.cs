using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public GameObject PauseUI;

	private bool paused = false;

	void Start(){

		PauseUI.SetActive(false);

	}

	void Update(){

		if(Input.GetButtonDown("YButton")){

			paused = !paused;

		}

			if(paused){

				PauseUI.SetActive(true); 
				Time.timeScale = 0;
			}

			if(!paused){

				PauseUI.SetActive(false);
				Time.timeScale = 1;
			}

	}

	public void DroneA(){

		Application.LoadLevel(0); 

	}

	public void DroneB(){

		Application.LoadLevel(1);  

	}

	public void DroneC(){

		Application.LoadLevel(2);  

	}

	public void Car(){

		Application.LoadLevel(3); 

	}

	public void Tank(){

		Application.LoadLevel(4);  

	}

}
