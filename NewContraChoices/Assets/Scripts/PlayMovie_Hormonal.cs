using UnityEngine;
using System.Collections;

public class PlayMovie_Hormonal : MonoBehaviour {

	int mouseCounter;

	void OnMouseDown(){
		Handheld.PlayFullScreenMovie ("miPlan_Horm_IUD_BW", Color.black, FullScreenMovieControlMode.CancelOnInput);
		Debug.Log ("Should be playing movie now");
	}
}
