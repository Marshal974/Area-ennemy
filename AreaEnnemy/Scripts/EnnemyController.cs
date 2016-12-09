using UnityEngine;

/***
 * 
 * \auteur : Exopole
 * \Date : 03/12/2016
 * 
 * Cette classe permet de controller l'ennemi. Ca cible, son mouvement vers la cible et ca position d'origine ainsi que ca rencontre avec un joueur vivant.
 * 
 */
public class EnnemyController : MonoBehaviour {
    public float speed;

    private GameObject target;

    private Vector3 posInitial;
    
    private void Start()
    {
        posInitial = transform.position;
    }

    void FixedUpdate()
    {

        if (target != null)
            goToPosition(target.transform.position);
        else
            goToPosition(posInitial);

    }

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (UtilsPlayers.isAlive(collision.gameObject))
            {
                UtilsPlayers.setAlive(collision.gameObject, false);

                if (collision.gameObject.Equals(target))
                {
                    target = null;
                }

            
            }
            
            

        }
    }

    public void setTarget(GameObject target)
    {
        this.target = target;
        goToPosition(target.transform.position);
    }
    

    public void goToPosition(Vector3 destination)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, destination, step);
    }





}
