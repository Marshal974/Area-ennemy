using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TargetDetection : MonoBehaviour {

    private GameObject target;


    float lerptime = 1f;
    float currentLerpTime;

    float moveDistance = 10f;

    Vector3 startPos;
    Vector3 endPos;

    bool isLerping = false;
    bool isCloseCombat = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("On entre en collision " + collision.gameObject.tag);
            target = collision.gameObject;

            //Lerp purpose
            updateLerpingParams();
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("On entre en collision " + collision.gameObject.tag);
            target = null;
            isLerping = false;
            
        }
    }



    private void updateLerpingParams()
    {
        endPos = target.transform.position;
        startPos = transform.position;
        currentLerpTime = 0f;
        isLerping = true;
    }


    /********************************  Gestion du contact en cole combat ******/


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("On entre en combat ");
        if (collision.gameObject.tag == "Player")
        {
            isCloseCombat = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
         Debug.Log("On sort du collision ");
        if (collision.gameObject.tag == "Player")
        {
            isCloseCombat = false;
        }
    }





    /******************************************************************/


    private void Update()
    {

        if (target != null && playerHasMoved())
            updateLerpingParams();


        if (isCloseCombat)
            isLerping = false;
        else
        {
            if (isLerping)
            {
                currentLerpTime += Time.deltaTime;

                if (currentLerpTime > lerptime)
                {
                    currentLerpTime = lerptime;
                }

                float perc = currentLerpTime / lerptime;
                transform.position = Vector3.Lerp(startPos, endPos, perc);
            }
        }
        
    }

    private bool playerHasMoved()
    {
        return endPos != target.transform.position;
    }

}
