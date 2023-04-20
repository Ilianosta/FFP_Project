using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KrownzFPP
{
    public interface iCharacter
    {
        public void SpecialAttack();
        public void Attack();
        public void TakeDamage(float amount);
        public void Die();
    }
}
