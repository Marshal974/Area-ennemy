"# Area-ennemy" 

Il y a deux fichiers intéressants : ZoneController.cs et EnnemyController.cs. Il y a aussi les classes Utils qui ne sont pas encore très
fournie mais qui à termes nous faciletera la tache.

<h1> ZoneController.cs : </h1>
<ul>
  <li>private
    <ul>
     <li>(GameObject) targetPlayer : le joueur ciblé </li> 
    </ul>
  </li>
  <li>public
    <ul>
      <li>(GameObject) ennemy : Permet de spécifier un ennemi à la zone</li>
    </ul>
  </li>
</ul>

Cette classe va permettre à l'ennemy de changer de cible si une autre est plus proche et en vie ou si la cible sort de la zone.


<h1> EnnemyController.cs : </h1>
<ul>
  <li>private
    <ul>
      <li>(GameObject) target : la cible de l'ennemi</li>
      <li>(Vector3) position initial: la position vers laquelle l'ennemy se dirigera s'il n'a pas de cible  </li> 
    </ul>
  </li>
  <li>public
    <ul>
      <li>(float) speed : vitesse de l'ennemi</li>
    </ul>
  </li>
</ul>

Cette classe permet de controller les déplacements de l'ennemi en lui spécifiant une cible ainsi que ca vitesse.



                    
