using UnityEngine;
using System.Collections;
using System.Linq;
using System.Security.Permissions;
using Assets.Scripts;

namespace Assets.Scripts
{

    public class ArmorManager : MonoBehaviour
    {
        /// <summary>
        /// resistances associated with armor manager, script uses first one found that matches damage type, if duplicates are round object later in array are ignored
        /// </summary>
        public ResistanceType[] Resistances = {
            new ResistanceType {DamageType = DamageType.Physical, ResistanceAmount = 0}
        };

        // Use this for initialization
        void Start()
        {

        }

        public int CalculateDamage(int damageAmount, DamageType type)
        {
            ResistanceType negatedType = Resistances.Where(x => x.DamageType.Equals(type)).FirstOrDefault();
            if (negatedType != null)
            {
                if (negatedType.ResistanceAmount != 0)
                {
                    int resistAmount = negatedType.ResistanceAmount/100; // make it a percentage
                    if (resistAmount < 0) // add more damage
                    {
                        return Mathf.RoundToInt(damageAmount/resistAmount);
                    }
                    else
                    {
                        return Mathf.RoundToInt(damageAmount*resistAmount);
                    }
                }
            }
            return damageAmount; // no resistance
        }
        [System.Serializable]
        public class ResistanceType
        {
            public DamageType DamageType;
            public int ResistanceAmount;
        }
    }
}
