//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEngine;

//namespace Assets._Project.Script.Characters
//{
//    public class Health
//    {
//        //Maxhealt
//        //currentHealth
//        public void ChangeHealth(int amount)
//        {
//            currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth); // Clamping är att spelaren inte kan ta skada när man är på noll och få mer hälsa när man har maxHP
//        }

//        void TakeDamage(int damage)
//        {
//            currentHealth -= damage;
//            healthbar.SetHealth(currentHealth);
//        }
//    }
//}
