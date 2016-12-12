
using UnityEngine;

public static class UtilsDistance
{
    /***
     * 
     * isMinDist : permet de savoir si la destination 1 (dest1) est la plus proche du point d'origine 
     * 
     * */
    public static bool isMinDist(GameObject origine, GameObject dest1, GameObject dest2)
    {
        return Vector3.Distance(origine.transform.position, dest1.transform.position) < Vector3.Distance(origine.transform.position, dest2.transform.position);
    }
}
