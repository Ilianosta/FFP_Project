using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;
namespace KrownzFPP
{
    public class Character : MonoBehaviour, iCharacter
    {
        public event Action OnSpeedChanged;
        [SerializeField] Stats stats;
        public float Speed
        {
            get { return stats.speed; }
            set
            {
                stats.speed = value;
                OnSpeedChanged?.Invoke();
            }
        }

        void Awake()
        {
            Speed = UnityEngine.Random.Range(1,5f);
        }
        public void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public void Attack()
        {
            Debug.Log("Attacking");
        }

        public void TakeDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            throw new NotImplementedException();
        }
    }
    [System.Serializable]
    public class Stats
    {
        public float health;
        public float armor;
        public float magicArmor;
        public float physicalDmg;
        public float magicalDmg;
        public float speed;
        public float critChance;
        public float critDmg;
        public SkillHolder[] skills;
    }
    public class SkillHolder { }
}
