using UnityEngine;
using System.Collections;

    

public class _enemyAttack : MonoBehaviour{

          void start()
          {
              int Choice;
              int Fire = 10;
              int Earth = 15;
              int Heal = 5;
              int Water = 20;
              int HP = 100;
              int EnemyHP = 100;

               for( Choice = 0; Choice < 5; Choice++)
        {
            if (Choice == 1)
            {
                HP -= Fire;
            }
            if (Choice == 2)
            {
                HP -= Earth;
            }
            if (Choice == 3)
            {
                HP -= Water;
            }
            if (Choice == 4)
            {
                EnemyHP += Heal;
            }

            Debug.Log("Generating Enemy Attack: " + Choice);
        }


          }
    
      

    
}


 



