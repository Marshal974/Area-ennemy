using System;
using UnityEngine;


/***
 * 
 * 
 * Authors : exopole
 * Date : 06/12/2016
 * 
 * Cette classe va regrouper certaines fonction utiles dans l'utilisation des différentes classes du player dans d'autres classes
 * 
 * 
 * */

public static class UtilsPlayers
{


    // check si le player est vivant
    public static bool isAlive(GameObject player)
    {
        return player.GetComponent<PlayerController>().alive;
    }

    // Change le status alive du joueur (true/false)
    public static void setAlive(GameObject player, bool isAlive)
    {
        player.GetComponent<PlayerController>().alive = isAlive;
    }


}
