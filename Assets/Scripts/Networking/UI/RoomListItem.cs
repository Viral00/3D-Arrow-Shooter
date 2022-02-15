using UnityEngine;
using Photon.Realtime;
using TMPro;

public class RoomListItem : MonoBehaviour
{
	[SerializeField] TMP_Text text;
	[SerializeField] GameLauncher _gameLauncher;

	RoomInfo info;

	public void SetUp(RoomInfo _info)
	{
		info = _info;
		text.text = _info.Name;
	}

	public void OnClick()
	{
		_gameLauncher.JoinRoom(info);
	}
}
