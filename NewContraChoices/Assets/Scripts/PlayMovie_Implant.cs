using UnityEngine;
using System.Collections;

public class PlayMovie_Implant : MonoBehaviour {

		int mouseCounter;

		void OnMouseDown(){
				Handheld.PlayFullScreenMovie ("MiPlan_Implant_BW", Color.black, FullScreenMovieControlMode.CancelOnInput);
				Debug.Log ("Should be playing movie now");
		}
}
