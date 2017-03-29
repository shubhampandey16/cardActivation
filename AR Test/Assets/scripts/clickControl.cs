using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class clickControl : MonoBehaviour {

	public EventSystem eventSystem;
	bool clickFlag = false;
	public Texture2D image = null;
	public bool showing = false;

	// Use this for initialization
	void Start () {

		Debug.Log("Starting!");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp()
	{
		if(!eventSystem.IsPointerOverGameObject()) {
			if (this.gameObject.name == "left_menu") {
				GameObject.Find ("rewards_popup").GetComponent<RewardsController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("rewards_popup").transform.localScale = new Vector3 (22, 26, 5);
			}

			else if (this.gameObject.name == "merchTrans1") {
				GameObject.Find ("merchTrans1_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans1_popup").transform.localScale = new Vector3 (52, 26, 5);
			}

			else if (this.gameObject.name == "merchTrans2") {
				GameObject.Find ("merchTrans2_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans2_popup").transform.localScale = new Vector3 (52, 26, 5);
			}

			else if (this.gameObject.name == "merchTrans3") {
				GameObject.Find ("merchTrans3_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans3_popup").transform.localScale = new Vector3 (52, 26, 5);
			}

			else if (this.gameObject.name == "merchTrans4") {
				GameObject.Find ("merchTrans4_popup").GetComponent<MerchController> ().isShowing = true;
				//yield return new WaitForSeconds (1);
				GameObject.Find ("merchTrans4_popup").transform.localScale = new Vector3 (52, 26, 5);
			}
		}
	}


}
