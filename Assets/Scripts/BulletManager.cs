using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public enum DamageType
    {
        Physical = 0x0,
        Fire= 0x1,
        Ice= 0x2,
        Poison=0x4
    }

    public class BulletManager : MonoBehaviour
    {
        /// <summary>
        /// inital damage inflicted
        /// </summary>
        public int damage = 1;

        /// <summary>
        /// Damage over time
        /// </summary>
        public bool hasDamageOverTime = false;

        /// <summary>
        /// number of seconds the dot is inflicted over
        /// </summary>
        public int damageTickSeconds = 8;

        /// <summary>
        /// Damage over time
        /// </summary>
        public int damageOverTime = 0;

        /// <summary>
        /// Type of damage sustained
        /// </summary>
        public DamageType damageType = DamageType.Physical;

        /// <summary>
        /// is this a shot from the enemy
        /// </summary>
        public bool isFromEnemy = false;

        // Use this for initialization
        void Start()
        {
            Destroy(gameObject, 20);
        }
    }
}
