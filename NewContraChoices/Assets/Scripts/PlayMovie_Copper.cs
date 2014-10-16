using UnityEngine;
using System.Collections;

public class PlayMovie_Copper : MonoBehaviour {

	int mouseCounter;

	void OnMouseDown(){
		Handheld.PlayFullScreenMovie ("MiPlan_CopperIUD.mov", Color.black, FullScreenMovieControlMode.CancelOnInput);
		//audio.Play();
		Debug.Log ("Should be playing copper movie now");
	}
}
