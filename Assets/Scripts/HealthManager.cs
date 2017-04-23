using System;
using UnityEngine;
using System.Collections;


namespace Assets.Scripts
{

    public enum MobileType
    {
        Player,
        Enemy,
        NPC
    }
    public class HealthManager : MonoBehaviour
    {

        /// <summary>
        /// Total max hitpoints
        /// </summary>
        public int MaxHp = 1;

        /// <summary>
        /// Defines whether the object is enemy, player or npc
        /// </summary>
        public MobileType EntityType = MobileType.Enemy;

        public void Damage(int damageAmount, DamageType type)
        {
            var armor = gameObject.GetComponent<ArmorManager>();
            if (armor != null)
            {
                damageAmount = armor.CalculateDamage(damageAmount, type);
            }
            if (currentHp - damageAmount < 0)
            {
                //dead
               // Destroy(gameObject);
            }
            else
            {
                currentHp -= damageAmount;
            }
        }

        public void Heal(int healAmount)
        {
            if (currentHp + healAmount > MaxHp)
            {
                currentHp = MaxHp;
            }
            else
            {
                currentHp += healAmount;
            }
        }

        // Use this for initialization
        void Awake()
        {
            currentHp = MaxHp;
        }
           
        void OnTriggerEnter2D(Collider2D other)
        {
           Debug.Log("Entering collision " + other.gameObject.tag);
            var damageScript = other.gameObject.GetComponent<DamageManager>();
            if (damageScript != null)
            {
                if ((damageScript.isFromEnemy && (EntityType == MobileType.Player || EntityType == MobileType.NPC)) || (!damageScript.isFromEnemy && EntityType == MobileType.Enemy))
                {
                    Damage(damageScript.damage, damageScript.damageType);
                }
            }
        }

        [HideInInspector] public int currentHp;
    }
}