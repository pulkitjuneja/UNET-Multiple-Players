using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ButtonHandlers : MonoBehaviour {

	public customNetworkManager networkManager;
	void Start () {
		var buttons = GetComponentsInChildren<Button> ();

		foreach (var button in buttons) {
			switch (button.gameObject.name) {
				case "SpawnGreenButton":
					button.onClick.AddListener (() => SpawnGreenPlayer ());
					break;
				case "SpawnBlueButton":
					button.onClick.AddListener (() => SpawnBluePlayer ());
					break;
				case "SpawnRedButton":
					button.onClick.AddListener (() => SpawnRedPlayer ());
					break;
			}
		}
	}

	void SpawnGreenPlayer () {
		PlayerInfoMessage msg = new PlayerInfoMessage (PlayerClass.green);
		var connection = NetworkManager.singleton.client.connection;
		ClientScene.AddPlayer (connection, 0, msg);
	}

	void SpawnBluePlayer () {
		PlayerInfoMessage msg = new PlayerInfoMessage (PlayerClass.blue);
		var connection = NetworkManager.singleton.client.connection;
		Debug.Log (connection);
		ClientScene.AddPlayer (connection, 0, msg);
	}

	void SpawnRedPlayer () {
		PlayerInfoMessage msg = new PlayerInfoMessage (PlayerClass.red);
		var connection = NetworkManager.singleton.client.connection;
		ClientScene.AddPlayer (connection, 0, msg);
	}

}