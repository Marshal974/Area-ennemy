using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/***
 * 
 * \auteur : Exopole
 * \Date : 03/12/2016
 * 
 * Cette classe permet de controller la zone d'action d'un ennemie. Il peut cibler les ennemis à l'intérieur tant qu'ils sont vivants. 
 * Il changeras de cible si une autres plus proches est présente ou si la cible est morte. Si aucune cible n'est présente il retournera à ca place d'origine
 * 
 */

public class ZoneController : MonoBehaviour {
    private GameObject targetPlayer;
    public GameObject ennemy;

    private string TAG = "ZoneController =>";


    private void FixedUpdate()
    {
        if (targetPlayer != null && !UtilsPlayers.isAlive(targetPlayer))
        {
            targetPlayer = null;
        }
    }



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            setTargetMinDist(other.gameObject);
        }
    }



    private void OnTriggerExit(Collider other)
    {
        
        if (targetPlayer != null && targetPlayer.Equals(other.gameObject))
        {
            targetPlayer = null; // le joueur sort de la zone d'action de l'ennemi
            setEnemyTargetPlayer(); // change la cible de l'ennemi
            
        }
    }


    private void setEnemyTargetPlayer()
    {
        ennemy.GetComponent<EnnemyController>().setTarget(targetPlayer);
    }

    // change pour la target la plus proche si celle ci est vivante
    private void setTargetMinDist(GameObject player1)
    {
        if ( UtilsPlayers.isAlive(player1) // !! pour moi la vérification que players est non nul a été faite avant l'entré dans cette fonction
            && (targetPlayer == null  
                || ! UtilsPlayers.isAlive(targetPlayer) 
                || ! UtilsDistance.isMinDist(this.ennemy, targetPlayer, player1)
                )
            )
            {
                this.targetPlayer = player1;
                setEnemyTargetPlayer();
            }
    }
   

}
