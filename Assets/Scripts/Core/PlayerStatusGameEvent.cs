using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStatusGameEvent", menuName = "Game Event/PlayerStatus")]
public class PlayerStatusGameEvent : GameEventBase<PlayerStatus>
{

}

[System.Serializable]
public struct PlayerStatus
{
    public string playerName;
    public int playerHealth;
    public int playerScore;
    public int playerLevel;
}
