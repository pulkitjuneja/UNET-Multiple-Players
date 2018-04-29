using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class customNetworkManager : NetworkManager {

	GameObject SpawnButtons;

	public GameObject bluePlayerPrefab, redPlayerPrefab, greenPlayerPrefab;

	void Awake () {
		DontDestroyOnLoad (this.gameObject);
		SpawnButtons = GameObject.Find ("SpawnButtons");
		SpawnButtons.SetActive (false); // we want this UI To be enabled only after the player connects to the server
	}

	public override void OnServerAddPlayer (NetworkConnection conn, short playerControllerId, NetworkReader extraMessagereader) {
		PlayerInfoMessage msg = extraMessagereader.ReadMessage<PlayerInfoMessage> ();
		Debug.Log (msg.playerClass);
		GameObject playerPrefab = spawnPlayerFromClass (msg.playerClass);
		NetworkServer.AddPlayerForConnection (conn, playerPrefab, playerControllerId);
	}

	public override void OnStartClient (NetworkClient client) {
		base.OnStartClient (client);
		SpawnButtons.SetActive (true);
	}

		public override void OnStopClient () {
		base.OnStopClient ();
		SpawnButtons.SetActive (false);
	}

	Vector3 getPositionOnPlane () {
		return new Vector3 (Random.Range (-8, 8), 1, Random.Range (-8, 8));
	}

	public GameObject spawnPlayerFromClass (PlayerClass playerClass) {
		GameObject playerPrefab = null;
		switch (playerClass) {
			case PlayerClass.blue:
				playerPrefab = bluePlayerPrefab;
				break;
			case PlayerClass.green:
				playerPrefab = greenPlayerPrefab;
				break;
			case PlayerClass.red:
				playerPrefab = redPlayerPrefab;
				break;
		}
		return GameObject.Instantiate (playerPrefab, getPositionOnPlane (), Quaternion.identity);
	}

}