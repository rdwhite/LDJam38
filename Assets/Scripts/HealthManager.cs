using System;
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


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

        public IEnumerator Damage(int damageAmount, DamageType type)
        {
            var armor = GetComponent<ArmorManager>();
            if (armor != null)
            {
                damageAmount = armor.CalculateDamage(damageAmount, type);
            }
            if (currentHp - damageAmount < 0)
            {
                currentHp = 0;
                //dead
                switch (EntityType)
                {
                    case MobileType.Player:
                        GameManager.instance.PlayerHasControl = false;
                        yield return new WaitForSeconds(5.0f);
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                        break;
                    case MobileType.Enemy:
                        var enemyScript = GetComponent<EnemyScript>();
                        if (enemyScript != null)
                        {
                            enemyScript.playDeath();
                        } else
                        {
                            Destroy(gameObject);
                        }
                        break;
                }
                 
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
            if (GameManager.instance.PlayerHasControl)
            {
                var damageScript = other.gameObject.GetComponent<DamageManager>();
                if (damageScript != null)
                {
                    if (damageScript.damage < 0) Heal(-damageScript.damage);
                    else
                    {
                        if ((damageScript.isFromEnemy && (EntityType == MobileType.Player || EntityType == MobileType.NPC)) ||
                            (!damageScript.isFromEnemy && EntityType == MobileType.Enemy))
                        {
                            StartCoroutine(Damage(damageScript.damage, damageScript.damageType));
                        }
                    }
                }
            }
        }

        [HideInInspector]
        public int currentHp;
    }
}