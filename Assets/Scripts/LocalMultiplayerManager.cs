using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiplayerManager : MonoBehaviour
{
    public List<Sprite> playerSprites;
    public List<PlayerInput> players;

    public void OnPlayerJoined(PlayerInput player) 
    {
        players.Add(player);

        SpriteRenderer sr = player.GetComponent<SpriteRenderer>();
        sr.sprite = playerSprites[player.playerIndex];

        LocalMultiplayerController controller = player.GetComponent<LocalMultiplayerController>();
        controller.manager = this;
    }

    public void PlayerAttacking(PlayerInput attackingPlayer) 
    {
        for (int i = 0; i < players.Count; i++) 
        {
            //Continue skips over the rest of the code and player that is currently attacking and adds onto i for the next loop
            if(attackingPlayer == players[i]) continue;

            if(Vector2.Distance(attackingPlayer.transform.position, players[i].transform.position) < 0.5f) 
            {
                Debug.Log("Player " + attackingPlayer.playerIndex + " has attacked Player " + players[i].playerIndex);
            }
        }
    }
}
